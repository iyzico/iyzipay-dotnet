using System;

namespace Iyzipay.Request
{
    public class CreateRefundRequest : BaseRequest
    {
        public String PaymentTransactionId { get; set; }
        public decimal? Price { get; set; }
        public String Ip { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentTransactionId", PaymentTransactionId)
                .AppendPrice("price", Price)
                .Append("ip", Ip)
                .GetRequestString();
        }
    }
}
