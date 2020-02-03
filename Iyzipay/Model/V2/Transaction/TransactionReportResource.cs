using System.Collections.Generic;

namespace Iyzipay.Model.V2.Transaction
{
    public class TransactionReportResource : IyzipayResourceV2
    {
        public int? CurrentPage { get; set; }
        public int? TotalPageCount { get; set; }
        public List<TransactionReportItem> Transactions { get; set; }
    }
}
