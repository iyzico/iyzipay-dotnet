using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class PaymentPostAuth : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String Price { get; set; }

        public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPostAuth>(options.BaseUrl + "/payment/iyzipos/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
