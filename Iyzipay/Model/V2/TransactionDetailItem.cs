using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyzipay.Model.V2
{
    public class TransactionDetailItem
    {
        public String TransactionType { get; set; }
        public String TransactionDate { get; set; }
        public long TransactionId { get; set; }
        public int AfterSettlement { get; set; }
        [JsonProperty(PropertyName = "paymentTxId")]
        public long PaymentTransactionId { get; set; }
        public long PaymentId { get; set; }
        public String ConversationId { get; set; }
        public String PaymentPhase { get; set; }
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public String TransactionCurrency { get; set; }
        public int Installment { get; set; }
        public int ThreeDS { get; set; }
        public String IyzicoCommission { get; set; }
        public String IyzicoFee { get; set; }
        public String Parity { get; set; }
        public String IyzicoConversionAmount { get; set; }
        public String SettlementCurrency { get; set; }
        public String MerchantPayoutAmount { get; set; }
        public String ConnectorType { get; set; }
        public String PosOrderId { get; set; }
        public String PosName { get; set; }
        public String SubMerchantKey { get; set; }
        public String SubMerchantPayoutAmount { get; set; }
        public String AuthCode { get; set; }
        public String HostReference { get; set; }
        public String BasketId { get; set; }
        public int? TransactionStatus { get; set; }
        public String Currency { get; set; }
        public String PaymentStatus { get; set; }
        public int? FraudStatus { get; set; }
        public String MerchantCommissionRate { get; set; }
        public String MerchantCommissionRateAmount { get; set; }
        public String IyziCommissionFee { get; set; }
        public String IyziCommissionRateAmount { get; set; }
        public String CardFamily { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardToken { get; set; }
        public String CardUserKey { get; set; }
        public String BinNumber { get; set; }
        [JsonProperty(PropertyName = "ItemTransactions")]
        public String ConnectorName { get; set; }
        public String Phase { get; set; }
        public String BlockageRate { get; set; }
        public String BlockageRateAmountMerchant { get; set; }
        public String BlockageRateAmountSubMerchant { get; set; }
        public String BlockageResolvedDate { get; set; }
        public String SubMerchantPayoutRate { get; set; }
        public String SubMerchantPrice { get; set; }
    }
}
