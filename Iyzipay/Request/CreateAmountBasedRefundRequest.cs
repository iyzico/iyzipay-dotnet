using System;
using Iyzipay.Model;
using System.Collections.Generic;

namespace Iyzipay.Request
{

    public class CreateAmountBasedRefundRequest : BaseRequest
    {
        public String PaymentId { get; set; }
        public String Price { get; set; }
        public String Ip { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentId", PaymentId)
                .AppendPrice("price", Price)
                .Append("ip", Ip)
                .GetRequestString();
        }
    }
}