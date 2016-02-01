using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class PaymentPostAuth : IyzipayResource
    {
        public String PaymentId { get; set; }
        public decimal? Price { get; set; }

        public static Task<PaymentPostAuth> Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return new RestHttpClient().Post<PaymentPostAuth>(options.BaseUrl + "/payment/iyzipos/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
