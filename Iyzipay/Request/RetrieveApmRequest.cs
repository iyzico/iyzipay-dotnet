using System;

namespace Iyzipay.Request
{
   public class RetrieveApmRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentId", PaymentId)
                .GetRequestString();
        }
    }
}
