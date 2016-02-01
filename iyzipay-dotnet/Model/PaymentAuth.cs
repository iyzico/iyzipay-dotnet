using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PaymentAuth : Payment
    {
        public static Task<PaymentAuth> Create(CreatePaymentRequest request, Options options)
        {
            return new RestHttpClient().Post<PaymentAuth>(options.BaseUrl + "/payment/iyzipos/auth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
