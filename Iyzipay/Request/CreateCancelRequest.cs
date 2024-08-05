using System;

namespace Iyzipay.Request
{
    public class CreateCancelRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string Ip { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }

    }
}
