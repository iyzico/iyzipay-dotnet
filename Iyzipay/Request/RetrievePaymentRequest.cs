using System;

namespace Iyzipay.Request
{
   public class RetrievePaymentRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string PaymentConversationId { get; set; }
    }
}
