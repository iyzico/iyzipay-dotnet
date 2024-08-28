﻿using System;

namespace Iyzipay.Request
{
    public class CreateRefundRequest : BaseRequestV2
    {
        public string PaymentTransactionId { get; set; }
        public string Price { get; set; }
        public string Ip { get; set; }
        public string Currency { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("paymentTransactionId", PaymentTransactionId)
                .AppendPrice("price", Price)
                .Append("ip", Ip)
                .Append("currency", Currency)
                .Append("reason", Reason)
                .Append("description", Description)
                .GetRequestString();
        }

    }
}
