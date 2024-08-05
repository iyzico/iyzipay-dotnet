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
    }
}