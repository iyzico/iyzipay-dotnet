using System;
using System.Collections.Generic;
using Iyzipay.Model;

namespace Iyzipay.Request
{
    public class CreateIyziupFormInitializeRequest : BaseRequest
    {
        public String MerchantOrderId { get; set; }
        public String PaymentGroup { get; set; }
        public String PaymentSource { get; set; }
        public int? ForceThreeDS { get; set; }
        public List<int> EnabledInstallments { get; set; }
        public String EnabledCardFamily { get; set; }
        public String Currency { get; set; }
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public String ShippingPrice { get; set; }
        public String CallbackUrl { get; set; }
        public String TermsUrl { get; set; }
        public String PreSalesContractUrl { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public InitialConsumer InitialConsumer { get; set; }
        
        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("merchantOrderId", MerchantOrderId)
                .Append("paymentGroup", PaymentGroup) 
                .Append("paymentSource", PaymentSource) 
                .Append("forceThreeDS", ForceThreeDS) 
                .Append("enabledInstallments", EnabledInstallments) 
                .Append("enabledCardFamily", EnabledCardFamily) 
                .Append("currency", Currency) 
                .Append("price", Price) 
                .Append("paidPrice", PaidPrice) 
                .Append("shippingPrice", ShippingPrice) 
                .Append("callbackUrl", CallbackUrl)
                .Append("termsUrl", TermsUrl)
                .Append("preSalesContractUrl", PreSalesContractUrl)
                .Append("orderItems", OrderItems)
                .Append("initialConsumer", InitialConsumer)
                .GetRequestString();
        }
    }
}