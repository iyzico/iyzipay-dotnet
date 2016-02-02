using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PaymentPreAuth : Payment
    {
        public static PaymentPreAuth Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPreAuth>(options.BaseUrl + "/payment/iyzipos/preauth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
