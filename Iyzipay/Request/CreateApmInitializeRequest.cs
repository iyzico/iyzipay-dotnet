using System;
using Iyzipay.Model;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreateApmInitializeRequest : BaseRequestV2
    {
        public string Price { get; set; }
        public string PaidPrice { get; set; }
        public string PaymentChannel { get; set; }
        public string PaymentGroup { get; set; }
        public string PaymentSource { get; set; }
        public string Currency { get; set; }
        public string BasketId { get; set; }
        public string MerchantOrderId { get; set; }
        public string CountryCode { get; set; }
        public string AccountHolderName { get; set; }
        public string MerchantCallbackUrl { get; set; }
        public string MerchantErrorUrl { get; set; }
        public string MerchantNotificationUrl { get; set; }
        public string ApmType { get; set; }
        public Buyer Buyer { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
