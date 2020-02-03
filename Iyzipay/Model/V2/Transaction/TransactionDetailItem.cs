using System;
using System.Collections.Generic;

namespace Iyzipay.Model.V2.Transaction
{
    public class TransactionDetailItem
    {
        public long PaymentId { get; set; }
        public int PaymentStatus { get; set; }
        public String PaymentRefundStatus { get; set; }
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String MerchantCommissionRate { get; set; }
        public String MerchantCommissionRateAmount { get; set; }
        public String IyziCommissionFee { get; set; }
        public String IyziCommissionRateAmount { get; set; }
        public String PaymentConversationId { get; set; }
        public int? FraudStatus { get; set; }
        public String CardFamily { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardToken { get; set; }
        public String CardUserKey { get; set; }
        public String BinNumber { get; set; }
        public String LastFourDigits { get; set; }
        public String BasketId { get; set; }
        public String Currency { get; set; }
        public String ConnectorName { get; set; }
        public String AuthCode { get; set; }
        public String HostReference { get; set; }
        public Boolean ThreeDS { get; set; }
        public String Phase { get; set; }
        public String AcquirerBankName { get; set; }
        public int? MdStatus { get; set; }
        public String CreatedDate { get; set; }
        public String UpdatedDate { get; set; }
        public String OrderId { get; set; }
        public List<TransactionDetailCancelItem> Cancels { get; set; }
        public List<PaymentTxDetailItem> ItemTransactions { get; set; }
    }
}
