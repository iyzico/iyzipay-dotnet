using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class CheckoutFormInitialize : IyzipayResource
    {
        public String Token { get; set; }
        public String CheckoutFormContent { get; set; }
        public long? TokenExpireTime { get; set; }
        public String PaymentPageUrl { get; set; }

        public static CheckoutFormInitialize Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutFormInitialize>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
