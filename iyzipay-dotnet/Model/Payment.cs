
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    class Payment : IyzipayResource
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String PaymentId { get; set; }
        public int FraudStatus { get; set; }
        public decimal? MerchantCommissionRate { get; set; }
        public decimal? MerchantCommissionRateAmount { get; set; }
        public decimal? IyziCommissionRateAmount { get; set; }
        public decimal? IyziCommissionFee { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public String CardToken { get; set; }
        public String CardUserKey { get; set; }
        public String BinNumber { get; set; }
        public String BasketId { get; set; }
        [JsonProperty(PropertyName = "itemTransactions")]
        private List<PaymentItem> PaymentItems { get; set; }
    }
}
