using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CheckoutFormAuth : Payment
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }
        public String PaymentStatus { get; set; }

        public static CheckoutFormAuth Retrieve(RetrieveCheckoutFormAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutFormAuth>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
