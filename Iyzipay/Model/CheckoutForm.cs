using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutForm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }

        private const string RetrieveUrl = "payment/iyzipos/checkoutform/auth/ecom/detail";
        public static CheckoutForm Retrieve(RetrieveCheckoutFormRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CheckoutForm>(RetrieveUrl, GetHttpHeaders(request, options), request);
        }

        public async static Task<CheckoutForm> RetrieveAsync(RetrieveCheckoutFormRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CheckoutForm>(RetrieveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }
    }
}
