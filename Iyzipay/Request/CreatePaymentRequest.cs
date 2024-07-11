using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreatePaymentRequest : BaseRequestV2
    {
        public string Price { get; set; }
        public string PaidPrice { get; set; }
        public int? Installment { get; set; }
        public string PaymentChannel { get; set; }
        public string BasketId { get; set; }
        public string PaymentGroup { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public Buyer Buyer { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public string PaymentSource { get; set; }
        public string CallbackUrl { get; set; }
        public string PosOrderId { get; set; }
        public string ConnectorName { get; set; }
        public string Currency { get; set; }
        public LoyaltyReward Reward { get; set; }
        public string GsmNumber { get; set; }

    }
}
