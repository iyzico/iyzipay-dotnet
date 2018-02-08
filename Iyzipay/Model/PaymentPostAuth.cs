using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPostAuth : PaymentResource
    {        
        public async static Task<PaymentPostAuth> CreateAsync(CreatePaymentPostAuthRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<PaymentPostAuth>("payment/postauth", GetHttpHeaders(request, options), request);
        }

        public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<PaymentPostAuth>("payment/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
