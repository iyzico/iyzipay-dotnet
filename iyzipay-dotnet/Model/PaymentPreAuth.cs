using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PaymentPreAuth : Payment
    {
        public static Task<PaymentPreAuth> Create(CreatePaymentRequest request, Options options)
        {
            return new RestHttpClient().Post<PaymentPreAuth>(options.BaseUrl + "/payment/iyzipos/preauth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
