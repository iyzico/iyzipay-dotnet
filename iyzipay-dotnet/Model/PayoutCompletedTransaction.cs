using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    class PayoutCompletedTransaction
    {
        public String PaymentTransactionId { get; set; }
        public decimal? PayoutAmount { get; set; }
        public String PayoutType { get; set; }
        public String SubMerchantKey { get; set; }
    }
}
