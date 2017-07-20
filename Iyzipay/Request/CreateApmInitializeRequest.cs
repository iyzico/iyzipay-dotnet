using System;
using Iyzipay.Model;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreateApmInitializeRequest : BaseRequest
    {
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public String PaymentChannel { get; set; }
        public String PaymentGroup { get; set; }
        public String PaymentSource { get; set; }
        public String Currency { get; set; }
        public String BasketId { get; set; }
        public String MerchantOrderId { get; set; }
        public String CountryCode { get; set; }
        public String AccountHolderName { get; set; }
        public String MerchantCallbackUrl { get; set; }
        public String MerchantErrorUrl { get; set; }
        public String MerchantNotificationUrl { get; set; }
        public String ApmType { get; set; }
        public Buyer Buyer { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public List<BasketItem> BasketItems { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .AppendPrice("price", Price)
                .AppendPrice("paidPrice", PaidPrice)
                .Append("paymentChannel", PaymentChannel)
                .Append("paymentGroup", PaymentGroup)
                .Append("paymentSource", PaymentSource)
                .Append("currency", Currency)
                .Append("merchantOrderId", MerchantOrderId)
                .Append("countryCode", CountryCode)
                .Append("accountHolderName", AccountHolderName)
                .Append("merchantCallbackUrl", MerchantCallbackUrl)
                .Append("merchantErrorUrl", MerchantErrorUrl)
                .Append("merchantNotificationUrl", MerchantNotificationUrl)
                .Append("apmType", ApmType)
                .Append("basketId", BasketId)
                .Append("buyer", Buyer)
                .Append("shippingAddress", ShippingAddress)
                .Append("billingAddress", BillingAddress)
                .AppendList("basketItems", BasketItems)
                .GetRequestString();
        }
    }
}
