using System;

namespace Iyzipay.Request
{
    public class CreateApprovalRequest : BaseRequestV2
    {
        public string PaymentTransactionId { get; set; }
    }
}
