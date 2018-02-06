using System;

namespace Iyzipay.Request
{
    public class CreateSubMerchantRequest : BaseRequest
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String GsmNumber { get; set; }
        public String Address { get; set; }
        public String Iban { get; set; }
        public String TaxOffice { get; set; }
        public String ContactName { get; set; }
        public String ContactSurname { get; set; }
        public String LegalCompanyTitle { get; set; }
        public String SubMerchantExternalId { get; set; }
        public String IdentityNumber { get; set; }
        public String TaxNumber { get; set; }
        public String SubMerchantType { get; set; }
        public String Currency { get; set; }
        public String SettlementDescriptionTemplate { get; set; }
        public String SwiftCode { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("name", Name)
                .Append("email", Email)
                .Append("gsmNumber", GsmNumber)
                .Append("address", Address)
                .Append("iban", Iban)
                .Append("taxOffice", TaxOffice)
                .Append("contactName", ContactName)
                .Append("contactSurname", ContactSurname)
                .Append("legalCompanyTitle", LegalCompanyTitle)
                .Append("swiftCode", SwiftCode)
                .Append("currency", Currency)
                .Append("settlementDescriptionTemplate", SettlementDescriptionTemplate)
                .Append("subMerchantExternalId", SubMerchantExternalId)
                .Append("identityNumber", IdentityNumber)
                .Append("taxNumber", TaxNumber)
                .Append("subMerchantType", SubMerchantType)
                .GetRequestString();
        }
    }
}
