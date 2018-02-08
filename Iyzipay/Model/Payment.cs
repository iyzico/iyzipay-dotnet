using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Payment : PaymentResource
    {
        private const string CreateUrl = "payment/auth";
        private const string RetrieveUrl = "payment/detail";
        public async static Task<Payment> CreateAsync(CreatePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Payment>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public async static Task<Payment> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Payment>(RetrieveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }


        public static Payment Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Payment>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public static Payment Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Payment>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }
    }
}
