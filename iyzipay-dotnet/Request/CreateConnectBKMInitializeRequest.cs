using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreateConnectBKMInitializeRequest : BaseRequest
    {
        public String ConnectorName { set; get; }
        public String Price { set; get; }
        public String CallbackUrl { set; get; }
        public String BuyerEmail {set;get;}
        public String BuyerId { set; get; }
        public String BuyerIp { set; get; }
        public String PosOrderId { set; get; }
        public List<BKMInstallment> InstallmentDetails { set; get; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("connectorName", ConnectorName)
                .AppendPrice("price", Price)
                .Append("callbackUrl", CallbackUrl)
                .Append("buyerEmail", BuyerEmail )
                .Append("buyerId", BuyerId)
                .Append("buyerIp", BuyerIp)
                .Append("posOrderId", PosOrderId)
                .AppendList("installmentDetails", InstallmentDetails)
                .GetRequestString();
        }
    }
}
