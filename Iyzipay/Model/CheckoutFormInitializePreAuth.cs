using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializePreAuth : CheckoutFormInitializeResource
    {
        public async static Task<CheckoutFormInitializePreAuth> CreateAsync(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CheckoutFormInitializePreAuth>("payment/iyzipos/checkoutform/initialize/preauth/ecom", GetHttpHeaders(request, options), request);
        }

        public static CheckoutFormInitializePreAuth Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CheckoutFormInitializePreAuth>("payment/iyzipos/checkoutform/initialize/preauth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
