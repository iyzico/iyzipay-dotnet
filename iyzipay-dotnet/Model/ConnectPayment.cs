using System;

namespace Iyzipay.Model
{
    class ConnectPayment : IyzipayResource
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String PaymentId { get; set; }
        public decimal? MerchantCommissionRate { get; set; }
        public decimal? MerchantCommissionRateAmount { get; set; }
        public decimal? IyziCommissionFee { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public String CardToken { get; set; }
        public String CardUserKey { get; set; }
        public String BinNumber { get; set; }
        public String PaymentTransactionId { get; set; }
        public String ConnectorName { get; set; }
    }
}
