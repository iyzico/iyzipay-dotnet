﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyzipay.Model.V2
{
    public class PaymentTxDetailItem
    {
        public String ItemId { get; set; }
        public String PaymentTransactionId { get; set; }
        public int? TransactionStatus { get; set; }
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public String MerchantCommissionRate { get; set; }
        public String MerchantCommissionRateAmount { get; set; }
        public String IyziCommissionRateAmount { get; set; }
        public String IyziCommissionFee { get; set; }
        public String BlockageRate { get; set; }
        public String BlockageRateAmountMerchant { get; set; }
        public String BlockageRateAmountSubMerchant { get; set; }
        public String BlockageResolvedDate { get; set; }
        public String SubMerchantKey { get; set; }
        public String SubMerchantPrice { get; set; }
        public String SubMerchantPayoutRate { get; set; }
        public String SubMerchantPayoutAmount { get; set; }
        public String MerchantPayoutAmount { get; set; }
        public ConvertedPayout ConvertedPayout { get; set; }
        public List<RefundDetailItem> Refunds { get; set; }
    }
}
