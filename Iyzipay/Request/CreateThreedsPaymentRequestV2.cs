using System;

namespace Iyzipay.Request
{
    public class CreateThreedsPaymentRequestV2 : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string PaidPrice { get; set; }
        public string BasketId { get; set; }
        public string Currency { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentId", PaymentId)
                .Append("paidPrice", PaidPrice)
                .Append("basketId", BasketId)
                .Append("currency", Currency)
                .GetRequestString();
        }
    }
}
