using System;

namespace Iyzipay.Request
{
    public class CreateThreedsPaymentRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string ConversationData { get; set; }
    }
}
