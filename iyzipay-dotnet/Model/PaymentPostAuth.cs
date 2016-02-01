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
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<PaymentPostAuth>(options.BaseUrl + "/payment/iyzipos/postauth", request);
        }
    }
}
