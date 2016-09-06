using Iyzipay.Model;
using System;

namespace Iyzipay.Request
{
    public class CreateBasicPaymentRequest : BaseRequest
    {
        public static readonly int? SINGLE_INSTALLMENT = 1;

        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String BuyerEmail { get; set; }
        public String BuyerId { get; set; }
        public String BuyerIp { get; set; }
        public String PosOrderId { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public String Currency { get; set; }
        public String ConnectorName { get; set; }
        public String CallbackUrl { get; set; }

        public CreateBasicPaymentRequest()
        {
            this.Installment = SINGLE_INSTALLMENT;
        }

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
                .Append("currency", Currency)
                .Append("connectorName", ConnectorName)
                .Append("callbackUrl", CallbackUrl)
                .GetRequestString();
        }
    }
}
