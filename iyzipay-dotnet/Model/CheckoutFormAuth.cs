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

        public static Task<CheckoutFormAuth> Retrieve(RetrieveCheckoutFormAuthRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<CheckoutFormAuth>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", request);
        }
    }
}
