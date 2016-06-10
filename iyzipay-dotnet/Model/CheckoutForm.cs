using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class CheckoutForm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }      

        public static CheckoutForm Retrieve(RetrieveCheckoutFormRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutForm>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
