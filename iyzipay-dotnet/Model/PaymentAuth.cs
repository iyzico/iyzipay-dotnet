using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PaymentAuth : Payment
    {
        public static Task<PaymentAuth> Create(CreatePaymentRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<PaymentAuth>(options.BaseUrl + "/payment/iyzipos/auth/ecom", request);
        }
    }
}
