using System;

namespace Iyzipay.Model
{
    class PaymentItem
    {
        public String ItemId { get; set; }
        public String PaymentTransactionId { get; set; }
        public int? TransactionStatus { get; set; }
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? MerchantCommissionRate { get; set; }
        public decimal? MerchantCommissionRateAmount { get; set; }
        public decimal? IyziCommissionRateAmount { get; set; }
        public decimal? IyziCommissionFee { get; set; }
        public decimal? BlockageRate { get; set; }
        public decimal? BlockageRateAmountMerchant { get; set; }
        public decimal? BlockageRateAmountSubMerchant { get; set; }
        public String BlockageResolvedDate { get; set; }
        public String SubMerchantKey { get; set; }
        public decimal? SubMerchantPrice { get; set; }
        public decimal? SubMerchantPayoutRate { get; set; }
        public decimal? SubMerchantPayoutAmount { get; set; }
        public decimal? MerchantPayoutAmount { get; set; }
    }
}
