using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializePreAuth : CheckoutFormInitializeResource
    {
        private const string CreateUrl = "payment/iyzipos/checkoutform/initialize/preauth/ecom";
        public async static Task<CheckoutFormInitializePreAuth> CreateAsync(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CheckoutFormInitializePreAuth>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static CheckoutFormInitializePreAuth Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CheckoutFormInitializePreAuth>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
