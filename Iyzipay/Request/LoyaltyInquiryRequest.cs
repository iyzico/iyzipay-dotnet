using System;
using Iyzipay.Model;

namespace Iyzipay.Request
{
    public class LoyaltyInquiryRequest : BaseRequest
    {
        public LoyaltyPaymentCard PaymentCard { set; get; }
        public string Currency { set; get; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentCard", PaymentCard.ToPKIRequestString())
                .Append("currency", Currency)
                .GetRequestString();
        }
    }
}
