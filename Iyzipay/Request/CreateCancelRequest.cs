using System;

namespace Iyzipay.Request
{
    public class CreateCancelRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string Ip { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }


        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentId", PaymentId)
                .Append("ip", Ip)
                .Append("reason", Reason)
                .Append("description", Description)
                .GetRequestString();
        }
    }
}
