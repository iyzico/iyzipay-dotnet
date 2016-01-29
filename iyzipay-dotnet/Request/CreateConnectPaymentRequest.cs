using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class CreateConnectPaymentRequest : BaseRequest
    {
        public static readonly int SINGLE_INSTALLMENT = 1;

        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String BuyerEmail { get; set; }
        public String BuyerId { get; set; }
        public String BuyerIp { get; set; }
        public String PosOrderId { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public String ConnectorName { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .AppendPrice("price", Price)
                .AppendPrice("paidPrice", PaidPrice)
                .Append("installment", Installment)
                .Append("buyerEmail", BuyerEmail)
                 .Append("buyerId", BuyerId)
                .Append("buyerIp", BuyerIp)
                .Append("posOrderId", PosOrderId)
                .Append("paymentCard", PaymentCard)
                 .Append("connectorName", ConnectorName)
                .GetRequestString();
        }

    }
}
