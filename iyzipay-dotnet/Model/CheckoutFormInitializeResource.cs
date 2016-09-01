using System;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializeResource : IyzipayResource
    {
        public String Token { get; set; }
        public String CheckoutFormContent { get; set; }
        public long? TokenExpireTime { get; set; }
        public String PaymentPageUrl { get; set; }
    }
}
