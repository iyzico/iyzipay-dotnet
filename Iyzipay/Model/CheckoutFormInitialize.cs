using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitialize : CheckoutFormInitializeResource
    {
        public async static Task<CheckoutFormInitialize> CreateAsync(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CheckoutFormInitialize>("payment/iyzipos/checkoutform/initialize/auth/ecom", GetHttpHeaders(request, options), request);
        }

        public static CheckoutFormInitialize Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CheckoutFormInitialize>("payment/iyzipos/checkoutform/initialize/auth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
