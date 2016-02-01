using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class Refund : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public decimal? Price { get; set; }

        public static Task<Refund> Create(CreateRefundRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<Refund>(options.BaseUrl + "/payment/iyzipos/refund", request);
        }
    }
}
