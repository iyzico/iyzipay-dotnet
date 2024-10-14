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


        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .AppendPrice("price", Price)
                .AppendPrice("paidPrice", PaidPrice)
                .Append("installment", Installment)
                .Append("paymentChannel", PaymentChannel)
                .Append("basketId", BasketId)
                .Append("paymentGroup", PaymentGroup)
                .Append("paymentCard", PaymentCard)
                .Append("buyer", Buyer)
                .Append("shippingAddress", ShippingAddress)
                .Append("billingAddress", BillingAddress)
                .AppendList("basketItems", BasketItems)
                .Append("paymentSource", PaymentSource)
                .Append("currency", Currency)
                .Append("posOrderId", PosOrderId)
                .Append("connectorName", ConnectorName)
                .Append("callbackUrl", CallbackUrl)
                .Append("gsmNumber", GsmNumber)
                .GetRequestString();
        }
    }
}
