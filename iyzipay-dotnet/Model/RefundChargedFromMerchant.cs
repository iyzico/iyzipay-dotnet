using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class RefundChargedFromMerchant : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public decimal? Price { get; set; }

        public static Task<RefundChargedFromMerchant> Create(CreateRefundRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<RefundChargedFromMerchant>(options.BaseUrl + "/payment/iyzipos/refund/merchant/charge", request);
        }
    }
}
