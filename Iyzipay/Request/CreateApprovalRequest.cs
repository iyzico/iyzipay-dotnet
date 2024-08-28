using System;

namespace Iyzipay.Request
{
    public class CreateApprovalRequest : BaseRequestV2
    {
        public string PaymentTransactionId { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentTransactionId", PaymentTransactionId)
                .GetRequestString();
        }
    }
}
