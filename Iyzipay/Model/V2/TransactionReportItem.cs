using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyzipay.Model.V2
{
    public class TransactionReportItem
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
    }
}
