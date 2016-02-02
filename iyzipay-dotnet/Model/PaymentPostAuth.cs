using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PaymentPostAuth : IyzipayResource
    {
        public String PaymentId { get; set; }
        public decimal? Price { get; set; }

        public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPostAuth>(options.BaseUrl + "/payment/iyzipos/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
