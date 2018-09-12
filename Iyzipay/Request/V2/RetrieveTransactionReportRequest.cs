using System;

namespace Iyzipay.Request.V2
{
    public class RetrieveTransactionReportRequest : BaseRequestV2
    {
        public String TransactionDate { get; set; }
        public int Page { get; set; }
    }
}