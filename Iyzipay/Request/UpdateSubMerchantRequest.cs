using System;

namespace Iyzipay.Request
{
    public class UpdateSubMerchantRequest : BaseRequestV2
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string GsmNumber { get; set; }
        public string Address { get; set; }
        public string Iban { get; set; }
        public string TaxOffice { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string LegalCompanyTitle { get; set; }
        public string SubMerchantKey { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxNumber { get; set; }
        public string Currency { get; set; }
        public string SettlementDescriptionTemplate { get; set; }
        public string SwiftCode { get; set; }

    }
}
