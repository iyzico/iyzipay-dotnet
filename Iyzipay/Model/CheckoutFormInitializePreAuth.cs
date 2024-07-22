using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializePreAuth : CheckoutFormInitializeResource
    {
        public static CheckoutFormInitializePreAuth Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            var uri = options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/preauth/ecom";
            return RestHttpClientV2.Create().Post<CheckoutFormInitializePreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri,options), request);
        }
    }
}
