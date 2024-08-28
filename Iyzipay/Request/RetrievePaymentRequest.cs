using System;

namespace Iyzipay.Request
{
   public class RetrievePaymentRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string PaymentConversationId { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentId", PaymentId)
                .Append("paymentConversationId", PaymentConversationId)
                .GetRequestString();
        }
    }
}
