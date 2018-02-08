using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitialize : CheckoutFormInitializeResource
    {
        private const string CreateUrl = "payment/iyzipos/checkoutform/initialize/auth/ecom";
        public async static Task<CheckoutFormInitialize> CreateAsync(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CheckoutFormInitialize>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static CheckoutFormInitialize Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CheckoutFormInitialize>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
