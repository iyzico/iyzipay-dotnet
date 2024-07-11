using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class CheckoutFormInitialize : CheckoutFormInitializeResource
    {
        public static CheckoutFormInitialize Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            var uri = options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/auth/ecom";
            return RestHttpClientV2.Create().Post<CheckoutFormInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
    }
}
