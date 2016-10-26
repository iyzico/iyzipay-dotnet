using System;

namespace Iyzipay.Model
{
    public class BasicPaymentResource : IyzipayResource
    {
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String Currency { get; set; }
        public String PaymentId { get; set; }
        public String MerchantCommissionRate { get; set; }
        public String MerchantCommissionRateAmount { get; set; }
        public String IyziCommissionFee { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public String CardToken { get; set; }
        public String CardUserKey { get; set; }
        public String BinNumber { get; set; }
        public String PaymentTransactionId { get; set; }
        public String AuthCode { get; set; }
        public String ConnectorName { get; set; }
        public String Phase { get; set; }
    }
}
