using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPostAuth : PaymentResource
    {        
        public static Task<PaymentPostAuth> Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<PaymentPostAuth>(options.BaseUrl + "/payment/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
