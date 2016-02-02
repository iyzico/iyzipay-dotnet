using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CheckoutFromInitialize : IyzipayResource
    {
        public String Token { get; set; }
        public String CheckoutFormContent { get; set; }
        public long? TokenExpireTime { get; set; }
        public String PaymentPageUrl { get; set; }

        public static BinNumber Retrieve(CreateCheckoutFromInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BinNumber>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/ecom", GetHttpHeaders(request, options), request);
        }

    }
}
