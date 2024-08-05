using System;

namespace Iyzipay.Request
{
    public class CreateCrossBookingRequest : BaseRequestV2
    {
        public string SubMerchantKey { get; set; }
        public string Price { get; set; }
        public string Reason { get; set; }
        public string Currency { get; set; }
    }
}
