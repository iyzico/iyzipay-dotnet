using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class BasicPayment : BasicPaymentResource
    {
        public static BasicPayment Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPayment>(options.BaseUrl + "/payment/aut/basic", GetHttpHeaders(request, options), request);
        }
    }
}
