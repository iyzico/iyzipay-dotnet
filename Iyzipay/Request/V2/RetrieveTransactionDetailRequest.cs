using System;

namespace Iyzipay.Request.V2
{
    public class RetrieveTransactionDetailRequest : BaseRequestV2
    {
        public String PaymentConversationId { get; set; }
    }
}