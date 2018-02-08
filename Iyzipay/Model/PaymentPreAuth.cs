using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPreAuth : PaymentResource
    {
        public async static Task<PaymentPreAuth> CreateAsync(CreatePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PaymentPreAuth>("payment/preauth", GetHttpHeaders(request, options), request);
        }

        public async static Task<PaymentPreAuth> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PaymentPreAuth>("payment/detail", GetHttpHeaders(request, options), request);
        }


        public  static PaymentPreAuth Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PaymentPreAuth>("payment/preauth", GetHttpHeaders(request, options), request);
        }

        public  static PaymentPreAuth Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PaymentPreAuth>("payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
