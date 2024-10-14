using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitialize : CheckoutFormInitializeResource
    {
        public static Task<CheckoutFormInitialize> Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            var uri = options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/auth/ecom";
            return RestHttpClientV2.Create().PostAsync<CheckoutFormInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
        }
    }
}
