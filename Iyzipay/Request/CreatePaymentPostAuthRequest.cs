using System;

namespace Iyzipay.Request
{
    public class CreatePaymentPostAuthRequest : BaseRequestV2
    {
        public string PaymentId { get; set; }
        public string PaidPrice { get; set; }
        public string Ip { get; set; }
        public string Currency { get; set; }
    }
}
