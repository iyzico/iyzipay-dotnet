using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreateBasicBkmInitializeRequest : BaseRequest
    {
        public String ConnectorName { get; set; }
        public String Price { get; set; }
        public String CallbackUrl { get; set; }
        public String BuyerEmail { get; set; }
        public String BuyerId { get; set; }
        public String BuyerIp { get; set; }
        public String PosOrderId { get; set; }
        public List<BkmInstallment> InstallmentDetails { get; set; }
        
        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("connectorName", ConnectorName)
                .AppendPrice("price", Price)
                .Append("callbackUrl", CallbackUrl)
                .Append("buyerEmail", BuyerEmail)
                .Append("buyerId", BuyerId)
                .Append("buyerIp", BuyerIp)
                .Append("posOrderId", PosOrderId)
                .AppendList("installmentDetails", InstallmentDetails)
                .GetRequestString();
        }
    }
}
