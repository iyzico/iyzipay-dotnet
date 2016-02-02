using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PaymentAuth : Payment
    {
        public static PaymentAuth Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentAuth>(options.BaseUrl + "/payment/iyzipos/auth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
