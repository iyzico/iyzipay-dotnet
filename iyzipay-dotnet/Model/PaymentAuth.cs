using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class PaymentAuth : Payment
    {
        public static PaymentAuth Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentAuth>(options.BaseUrl + "/payment/iyzipos/auth/ecom", GetHttpHeaders(request, options), request);
        }

        public static PaymentAuth Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentAuth>(options.BaseUrl + "/payment/detail/", GetHttpHeaders(request, options), request);
        }
    }
}
