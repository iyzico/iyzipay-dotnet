using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class CreateBasicPaymentRequest : BaseRequestV2
    {
        public static readonly int? SINGLE_INSTALLMENT = 1;

        public string Price { get; set; }
        public string PaidPrice { get; set; }
        public int? Installment { get; set; }
        public string BuyerEmail { get; set; }
        public string BuyerId { get; set; }
        public string BuyerIp { get; set; }
        public string PosOrderId { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public string Currency { get; set; }
        public string ConnectorName { get; set; }
        public string CallbackUrl { get; set; }

        public CreateBasicPaymentRequest()
        {
            this.Installment = SINGLE_INSTALLMENT;
        }

        public override string ToPKIRequestString()
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
                .Append("currency", Currency)
                .Append("connectorName", ConnectorName)
                .Append("callbackUrl", CallbackUrl)
                .GetRequestString();
        }
    }
}
