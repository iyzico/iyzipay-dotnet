using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class BasicPaymentPreAuth : BasicPaymentResource
    {
        public static BasicPaymentPreAuth Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPaymentPreAuth>(options.BaseUrl + "/payment/preauth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
