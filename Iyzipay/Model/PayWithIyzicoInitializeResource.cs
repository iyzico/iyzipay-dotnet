using System;

namespace Iyzipay.Model
{
    public class PayWithIyzicoInitializeResource : IyzipayResourceV2
    {
        public string Token { get; set; }
        public string CheckoutFormContent { get; set; }
        public long? TokenExpireTime { get; set; }
        public string PayWithIyzicoPageUrl { get; set; }
    }
}
