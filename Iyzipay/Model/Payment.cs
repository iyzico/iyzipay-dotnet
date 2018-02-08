using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Payment : PaymentResource
    {
        public async static Task<Payment> CreateAsync(CreatePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Payment>("payment/auth", GetHttpHeaders(request, options), request);
        }

        public async static Task<Payment> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Payment>("payment/detail", GetHttpHeaders(request, options), request);
        }


        public static Payment Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Payment>("payment/auth", GetHttpHeaders(request, options), request);
        }

        public static Payment Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Payment>("payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
