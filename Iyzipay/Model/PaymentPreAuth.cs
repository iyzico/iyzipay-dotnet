using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPreAuth : PaymentResource
    {
        private const string CreateUrl = "payment/preauth";
        private const string RetrieveUrl = "payment/detail";
        public async static Task<PaymentPreAuth> CreateAsync(CreatePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PaymentPreAuth>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public async static Task<PaymentPreAuth> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PaymentPreAuth>(RetrieveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }


        public static PaymentPreAuth Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PaymentPreAuth>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public static PaymentPreAuth Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PaymentPreAuth>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
