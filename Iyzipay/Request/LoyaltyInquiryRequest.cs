using System;
using Iyzipay.Model;

namespace Iyzipay.Request
{
    public class LoyaltyInquiryRequest : BaseRequestV2
    {
        public LoyaltyPaymentCard PaymentCard { set; get; }
        public string Currency { set; get; }
    }
}
