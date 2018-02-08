using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutForm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }

        public static CheckoutForm Retrieve(RetrieveCheckoutFormRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CheckoutForm>("payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }

        public async static Task<CheckoutForm> RetrieveAsync(RetrieveCheckoutFormRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CheckoutForm>("payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
