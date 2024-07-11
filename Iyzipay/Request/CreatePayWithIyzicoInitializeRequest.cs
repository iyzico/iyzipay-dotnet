using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreatePayWithIyzicoInitializeRequest : BaseRequestV2
    {
        public string Price { get; set; }
        public string PaidPrice { get; set; }
        public string BasketId { get; set; }
        public string PaymentGroup { get; set; }
        public string PaymentSource { get; set; }
        public string Currency { get; set; }
        public Buyer Buyer { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public string CallbackUrl { get; set; }
        public int? ForceThreeDS { get; set; }
        public string CardUserKey { get; set; }
        public string PosOrderId { get; set; }
        public List<int> EnabledInstallments { get; set; }
    }
}
