using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializePreAuth : CheckoutFormInitializeResource
    {
        public static Task<CheckoutFormInitializePreAuth> Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            var uri = options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/preauth/ecom";

            return RestHttpClientV2.Create().PostAsync<CheckoutFormInitializePreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri,options), request);
        }
    }
}
