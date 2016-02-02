using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace iyzipay_dotnet_sample.Sample
{
    [TestClass]
    public class PostAuthSample : Sample
    {
        [TestMethod]
        public void Should_Post_Auth()
        {
            CreatePaymentPostAuthRequest request = new CreatePaymentPostAuthRequest();
            request.ConversationId = "123456";
            request.Locale = Locale.TR.GetName();
            request.PaymentId = "1";
            request.Ip = "127.0.0.1";

            PaymentPostAuth paymentPostAuth = PaymentPostAuth.Create(request, options);
            Assert.IsNotNull(paymentPostAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), paymentPostAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), paymentPostAuth.Locale);
            Assert.AreEqual("123456789", paymentPostAuth.ConversationId);
            Assert.AreEqual("1", paymentPostAuth.PaymentId);
        }
    }
}
