using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreateCheckoutFormInitializeRequest : BaseRequestV2
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

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .AppendPrice("price", Price)
                .Append("basketId", BasketId)
                .Append("paymentGroup", PaymentGroup)
                .Append("buyer", Buyer)
                .Append("shippingAddress", ShippingAddress)
                .Append("billingAddress", BillingAddress)
                .AppendList("basketItems", BasketItems)
                .Append("callbackUrl", CallbackUrl)
                .Append("paymentSource", PaymentSource)
                .Append("currency", Currency)
                .Append("posOrderId", PosOrderId)
                .AppendPrice("paidPrice", PaidPrice)
                .Append("forceThreeDS", ForceThreeDS)
                .Append("cardUserKey", CardUserKey)
                .AppendList("enabledInstallments", EnabledInstallments)
                .GetRequestString();
        }
    }
}
