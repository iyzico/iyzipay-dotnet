using System;
using Iyzipay.Model;
using System.Collections.Generic;

namespace Iyzipay.Request
{

    public class CreateAmountBasedRefundRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string Price { get; set; }
        public string Ip { get; set; }

        public override string ToPKIRequestString()
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