using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreateBkmInitializeRequest : BaseRequestV2
    {
        public string Price { get; set; }
        public string BasketId { get; set; }
        public string PaymentGroup { get; set; }
        public string PaymentSource { get; set; }
        public Buyer Buyer { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public string CallbackUrl { get; set; }
		public List<int> EnabledInstallments { get; set; }
    }
}
