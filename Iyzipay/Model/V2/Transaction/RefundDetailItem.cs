using System;

namespace Iyzipay.Model.V2.Transaction
{
    public class RefundDetailItem
    {
        public long RefundTxId { get; set; }
        public String RefundConversationId { get; set; }
        public String RefundPrice { get; set; }
        public String CurrencyCode { get; set; }
        public String HostReference { get; set; }
        public String AuthCode { get; set; }
        public int RefundStatus { get; set; }
        public Boolean isAfterSettlement { get; set; }
        public String CreatedDate { get; set; }
        public String ErrorGroup { get; set; }
        public String ErrorCode { get; set; }
        public String ErrorMessage { get; set; }
    }
}
