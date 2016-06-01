using System;

namespace Iyzipay.Request
{
    public class CreatePaymentPostAuthRequest : BaseRequest
    {
        public String PaymentId { get; set; }
        public String PaidPrice { get; set; }
        public String Ip { get; set; }
        public String Currency { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentId", PaymentId)                
                .Append("ip", Ip)
                .AppendPrice("paidPrice", PaidPrice)
                .Append("currency", Currency)
                .GetRequestString();
        }
    }
}
