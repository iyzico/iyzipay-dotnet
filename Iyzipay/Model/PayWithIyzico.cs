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
            var uri = options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail";
            return RestHttpClientV2.Create().Post<PayWithIyzico>(uri, GetHttpHeadersWithRequestBody(request, uri,options), request);
        }
    }
}
