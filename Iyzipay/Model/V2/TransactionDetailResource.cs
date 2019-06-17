using System.Collections.Generic;

namespace Iyzipay.Model.V2
{
    public class TransactionDetailResource : IyzipayResourceV2
    {
        public List<TransactionDetailItem> Transactions { get; set; }
    }
}
