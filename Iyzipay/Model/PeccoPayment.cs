using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PeccoPayment : PaymentResource
    {
        public String Token { get; set; }

        private const string CreateUrl = "payment/pecco/auth";
        public async static Task<PeccoPayment> CreateAsync(CreatePeccoPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PeccoPayment>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static PeccoPayment Create(CreatePeccoPaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PeccoPayment>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
