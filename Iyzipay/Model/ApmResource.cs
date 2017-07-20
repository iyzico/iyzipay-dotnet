using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class ApmResource : IyzipayResource
    {
        public String RedirectUrl { get; set; }
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public String PaymentId { get; set; }
        public String MerchantCommissionRate { get; set; }
        public String MerchantCommissionRateAmount { get; set; }
        public String IyziCommissionRateAmount { get; set; }
        public String IyziCommissionFee { get; set; }
        public String BasketId { get; set; }
        public String Currency { get; set; }
        [JsonProperty(PropertyName = "itemTransactions")]
        public List<PaymentItem> PaymentItems { get; set; }
        public String Phase { get; set; }
        public String AccountHolderName { get; set; }
        public String AccountNumber { get; set; }
        public String BankName { get; set; }
        public String BankCode { get; set; }
        public String Bic { get; set; }
        public String PaymentPurpose { get; set; }
        public String Iban { get; set; }
        public String CountryCode { get; set; }
        public String Apm { get; set; }
        public String MobilePhone { get; set; }
        public String PaymentStatus { get; set; }         
    }
}
