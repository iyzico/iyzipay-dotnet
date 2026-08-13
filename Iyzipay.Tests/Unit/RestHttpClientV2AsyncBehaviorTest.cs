using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Unit
{
    /// <summary>
    /// RestHttpClientV2 (bkz. Iyzipay/RestHttpClientV2.cs) içindeki PostAsync/PutAsync/DeleteAsync
    /// metotları daha önce "HttpClient.SendAsync(requestMessage).Result" ile senkron bekliyordu
    /// (sync-over-async). Bu, çağıran thread'i alt seviye HTTP yanıtı tamamlanana kadar bloke ederdi.
    /// Yük altında bu davranış, uygulamanın request worker'larını tüketerek thread-pool kıtlığına katkıda
    /// bulunabilir (bkz. iyzico/iyzipay-dotnet#74); tek başına isteğin ağa çıkmadığını ispatlamaz.
    ///
    /// Bu test, gerçek bir loopback HTTP sunucusunun yanıtını kasıtlı olarak geciktirerek,
    /// Payment.Create(...) çağrısının -sunucu henüz yanıt vermemişken- çağıran thread'i bloke
    /// etmeden, tamamlanmamış bir Task döndürerek kontrolü geri verdiğini doğrular.
    /// Regresyon durumunda (yani "SendAsync(...).Result" tekrar kullanılırsa) çağrı, sunucu yanıt
    /// verene kadar hiç dönmez ve bu test zaman aşımına uğrayarak başarısız olur.
    /// </summary>
    [TestFixture]
    public class RestHttpClientV2AsyncBehaviorTest
    {
        [Test]
        public void PostAsync_Returns_Control_Before_Underlying_Http_Response_Completes()
        {
            int port = GetFreeLoopbackPort();
            var listener = new HttpListener();
            listener.Prefixes.Add($"http://127.0.0.1:{port}/");
            listener.Start();

            var releaseResponse = new TaskCompletionSource<bool>();

            try
            {
                var serverTask = Task.Run(async () =>
                {
                    HttpListenerContext ctx = await listener.GetContextAsync();
                    // Sunucu yanıtı kasıtlı olarak geciktiriyor; gerçek bir "istek gitti ama
                    // cevap gelmedi" penceresi oluşturuyoruz.
                    await releaseResponse.Task;

                    byte[] bytes = Encoding.UTF8.GetBytes("{ \"status\": \"success\", \"conversationId\": \"unit-test\" }");
                    ctx.Response.ContentType = "application/json";
                    ctx.Response.ContentLength64 = bytes.Length;
                    ctx.Response.OutputStream.Write(bytes, 0, bytes.Length);
                    ctx.Response.OutputStream.Close();
                });

                var request = new CreatePaymentRequest { ConversationId = "unit-test" };
                var options = new Options { ApiKey = "x", SecretKey = "y", BaseUrl = $"http://127.0.0.1:{port}" };

                Task<Payment> callTask = null;

                // Payment.Create çağrısını ayrı bir thread'de başlatıyoruz: içeride hâlâ
                // "SendAsync(...).Result" kullanılıyor olsaydı bu thread, sunucu yanıt verene
                // kadar -yani releaseResponse tamamlanana kadar- bloke kalır ve invokeTask
                // asla zamanında tamamlanmazdı.
                var invokeTask = Task.Run(() =>
                {
                    callTask = Payment.Create(request, options);
                });

                bool returnedPromptly = invokeTask.Wait(TimeSpan.FromSeconds(5));

                Assert.IsTrue(returnedPromptly,
                    "Payment.Create(...) çağrısı, sunucu yanıt vermeden çağırana dönmedi. " +
                    "Bu, RestHttpClientV2 içinde 'SendAsync(...).Result' kullanan bir sync-over-async regresyonuna işaret eder.");

                Assert.NotNull(callTask);
                Assert.IsFalse(callTask.IsCompleted,
                    "Dönen Task, sunucu henüz yanıt vermeden tamamlanmış görünüyor; test kurgusu beklenmedik şekilde bozulmuş.");

                // Şimdi sunucunun yanıt vermesine izin verip uçtan uca akışın (deserialize + header append) doğru çalıştığını doğrula.
                releaseResponse.SetResult(true);

                bool completed = callTask.Wait(TimeSpan.FromSeconds(5));
                Assert.IsTrue(completed, "Payment.Create(...) sunucu yanıt verdikten sonra makul sürede sonuçlanmadı.");
                Assert.AreEqual("success", callTask.Result.Status);
                Assert.AreEqual("unit-test", callTask.Result.ConversationId);

                serverTask.Wait(TimeSpan.FromSeconds(5));
            }
            finally
            {
                if (!releaseResponse.Task.IsCompleted)
                {
                    releaseResponse.TrySetResult(true);
                }
                listener.Stop();
                listener.Close();
            }
        }

        [Test]
        public void ConcurrentPostAsyncCalls_DoNot_Block_ThreadPoolWorkers_While_Responses_Are_Delayed()
        {
            const int concurrency = 32;
            int port = GetFreeLoopbackPort();
            var listener = new HttpListener();
            listener.Prefixes.Add($"http://127.0.0.1:{port}/");
            listener.Start();

            var releaseResponses = new TaskCompletionSource<bool>();
            var responseTasks = new Task[concurrency];

            try
            {
                var serverTask = Task.Run(async () =>
                {
                    for (int i = 0; i < concurrency; i++)
                    {
                        HttpListenerContext context = await listener.GetContextAsync();
                        responseTasks[i] = Task.Run(async () =>
                        {
                            await releaseResponses.Task;

                            byte[] bytes = Encoding.UTF8.GetBytes("{ \"status\": \"success\" }");
                            context.Response.ContentType = "application/json";
                            context.Response.ContentLength64 = bytes.Length;
                            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                            context.Response.OutputStream.Close();
                        });
                    }
                });

                var options = new Options
                {
                    ApiKey = "x",
                    SecretKey = "y",
                    BaseUrl = $"http://127.0.0.1:{port}"
                };

                var startGate = new ManualResetEventSlim(false);
                var paymentTasks = new Task<Payment>[concurrency];
                var callerTasks = new Task[concurrency];

                for (int i = 0; i < concurrency; i++)
                {
                    int index = i;
                    callerTasks[index] = Task.Run(() =>
                    {
                        startGate.Wait();
                        paymentTasks[index] = Payment.Create(
                            new CreatePaymentRequest { ConversationId = "concurrent-" + index },
                            options);
                    });
                }

                // Payment.Create, gerçek uygulamada olduğu gibi ThreadPool worker'larından eşzamanlı çağrılır.
                // Eski SendAsync(...).Result uygulamasında worker'lar, aşağıdaki releaseResponses tamamlanana
                // kadar bloklanır ve bu WaitAll kısa sürede tamamlanmaz.
                startGate.Set();
                bool callersReturnedPromptly = Task.WaitAll(callerTasks, TimeSpan.FromSeconds(5));

                Assert.IsTrue(callersReturnedPromptly,
                    "Gecikmiş HTTP yanıtları sırasında paralel Payment.Create çağrıları worker thread'lerini bloke etti.");
                Assert.IsTrue(Array.TrueForAll(paymentTasks, task => task != null && !task.IsCompleted),
                    "HTTP yanıtları serbest bırakılmadan önce Payment.Create sonuçlarından biri tamamlandı; test sunucusu beklenen gecikmeyi uygulamadı.");

                releaseResponses.SetResult(true);

                Assert.IsTrue(Task.WaitAll(paymentTasks, TimeSpan.FromSeconds(15)),
                    "Gecikmiş yanıtlar serbest bırakıldıktan sonra tüm ödeme çağrıları tamamlanmadı.");
                Assert.IsTrue(serverTask.Wait(TimeSpan.FromSeconds(15)),
                    "Test HTTP sunucusu tüm istekleri kabul etmedi.");
                Assert.IsTrue(Task.WaitAll(responseTasks, TimeSpan.FromSeconds(15)),
                    "Test HTTP sunucusu tüm yanıtları tamamlamadı.");
            }
            finally
            {
                releaseResponses.TrySetResult(true);
                listener.Stop();
                listener.Close();
            }
        }

        private static int GetFreeLoopbackPort()
        {
            var socket = new System.Net.Sockets.TcpListener(IPAddress.Loopback, 0);
            socket.Start();
            int port = ((IPEndPoint)socket.LocalEndpoint).Port;
            socket.Stop();
            return port;
        }
    }
}
