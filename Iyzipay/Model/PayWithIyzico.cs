using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class PayWithIyzico : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }      

        public static PayWithIyzico Retrieve(RetrievePayWithIyzicoRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PayWithIyzico>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
