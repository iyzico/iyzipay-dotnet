using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class PaymentPreAuth : Payment
    {
        public static PaymentPreAuth Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPreAuth>(options.BaseUrl + "/payment/iyzipos/preauth/ecom", GetHttpHeaders(request, options), request);
        }

        public static PaymentPreAuth Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPreAuth>(options.BaseUrl + "/payment/detail/", GetHttpHeaders(request, options), request);
        }
    }
}
