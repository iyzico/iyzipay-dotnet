using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializePreAuth : CheckoutFormInitializeResource
    {
        public static Task<CheckoutFormInitializePreAuth> Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<CheckoutFormInitializePreAuth>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/preauth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
