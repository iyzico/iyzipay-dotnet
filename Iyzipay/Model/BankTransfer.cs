using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class BankTransfer
    {
        public String SubMerchantKey { get; set; }
        public String Iban { get; set; }
        public String ContactName { get; set; }
        public String ContactSurname { get; set; }
        public String LegalCompanyTitle { get; set; }
        [JsonProperty(PropertyName= "marketplaceSubmerchantType")]
        public String MarketplaceSubMerchantType { get; set; }
    }
}
