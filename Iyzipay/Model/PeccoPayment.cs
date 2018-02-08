using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PeccoPayment : PaymentResource
    {
        public String Token { get; set; }

        public async static Task<PeccoPayment> CreateAsync(CreatePeccoPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PeccoPayment>("payment/pecco/auth", GetHttpHeaders(request, options), request);
        }

        public static PeccoPayment Create(CreatePeccoPaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PeccoPayment>("payment/pecco/auth", GetHttpHeaders(request, options), request);
        }
    }
}
