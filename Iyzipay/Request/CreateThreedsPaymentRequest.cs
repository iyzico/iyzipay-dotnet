using System;

namespace Iyzipay.Request
{
    public class CreateThreedsPaymentRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string ConversationData { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentId", PaymentId)
                .Append("conversationData", ConversationData)
                .GetRequestString();
        }
    }
}
