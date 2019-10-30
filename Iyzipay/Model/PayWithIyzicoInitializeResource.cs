using System;

namespace Iyzipay.Model
{
    public class PayWithIyzicoInitializeResource : IyzipayResource
    {
        public String Token { get; set; }
        public String CheckoutFormContent { get; set; }
        public long? TokenExpireTime { get; set; }
        public String PayWithIyzicoPageUrl { get; set; }
    }
}
