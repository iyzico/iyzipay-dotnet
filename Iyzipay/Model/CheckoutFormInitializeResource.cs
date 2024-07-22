using System;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializeResource : IyzipayResourceV2
    {
        public string Token { get; set; }
        public string CheckoutFormContent { get; set; }
        public long? TokenExpireTime { get; set; }
        public string PaymentPageUrl { get; set; }
    }
}
