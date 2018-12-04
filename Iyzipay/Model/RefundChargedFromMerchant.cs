using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class RefundChargedFromMerchant : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }
        public String AuthCode { get; set; }
        public String HostReference { get; set; }

        public static RefundChargedFromMerchant Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create().Post<RefundChargedFromMerchant>(options.BaseUrl + "/payment/iyzipos/refund/merchant/charge", GetHttpHeaders(request, options), request);
        }
    }
}
