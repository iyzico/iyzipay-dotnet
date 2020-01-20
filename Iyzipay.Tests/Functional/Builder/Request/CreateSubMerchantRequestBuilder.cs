using Iyzipay.Request;
using Iyzipay.Tests.Functional.Util;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class CreateSubMerchantRequestBuilder : BaseRequestBuilder
    {
        private string _name = "John's market";
        private string _email = "email@submerchantemail.com";
        private string _gsmNumber = "+905350000000";
        private string _address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        private string _iban = "TR180006200119000006672315";
        private string _currency = Model.Currency.TRY.ToString();
        private string _taxOffice;
        private string _contactName;
        private string _contactSurname;
        private string _legalCompanyTitle;
        private string _subMerchantExternalId;
        private string _identityNumber;
        private string _taxNumber;
        private string _subMerchantType;
        private string _swiftCode;

        private CreateSubMerchantRequestBuilder()
        {
        }

        public static CreateSubMerchantRequestBuilder Create()
        {
            return new CreateSubMerchantRequestBuilder();
        }

        public CreateSubMerchantRequestBuilder Name(string name)
        {
            _name = name;
            return this;
        }

        public CreateSubMerchantRequestBuilder Email(string email)
        {
            _email = email;
            return this;
        }

        public CreateSubMerchantRequestBuilder GsmNumber(string gsmNumber)
        {
            _gsmNumber = gsmNumber;
            return this;
        }

        public CreateSubMerchantRequestBuilder Address(string address)
        {
            _address = address;
            return this;
        }

        public CreateSubMerchantRequestBuilder Iban(string iban)
        {
            _iban = iban;
            return this;
        }

        public CreateSubMerchantRequestBuilder TaxOffice(string taxOffice)
        {
            _taxOffice = taxOffice;
            return this;
        }

        public CreateSubMerchantRequestBuilder ContactName(string contactName)
        {
            _contactName = contactName;
            return this;
        }

        public CreateSubMerchantRequestBuilder ContactSurname(string contactSurname)
        {
            _contactSurname = contactSurname;
            return this;
        }

        public CreateSubMerchantRequestBuilder LegalCompanyTitle(string legalCompanyTitle)
        {
            _legalCompanyTitle = legalCompanyTitle;
            return this;
        }

        public CreateSubMerchantRequestBuilder SubMerchantExternalId(string subMerchantExternalId)
        {
            _subMerchantExternalId = subMerchantExternalId;
            return this;
        }

        public CreateSubMerchantRequestBuilder IdentityNumber(string identityNumber)
        {
            _identityNumber = identityNumber;
            return this;
        }

        public CreateSubMerchantRequestBuilder TaxNumber(string taxNumber)
        {
            _taxNumber = taxNumber;
            return this;
        }

        public CreateSubMerchantRequestBuilder SubMerchantType(string subMerchantType)
        {
            _subMerchantType = subMerchantType;
            return this;
        }

        public CreateSubMerchantRequestBuilder Currency(string currency)
        {
            _currency = currency;
            return this;
        }

        public CreateSubMerchantRequestBuilder SwiftCode(string swiftCode)
        {
            _swiftCode = swiftCode;
            return this;
        }

        public CreateSubMerchantRequest Build()
        {
            CreateSubMerchantRequest createSubMerchantRequest = new CreateSubMerchantRequest();
            createSubMerchantRequest.Locale = _locale;
            createSubMerchantRequest.ConversationId = _conversationId;
            createSubMerchantRequest.Name = _name;
            createSubMerchantRequest.Email = _email;
            createSubMerchantRequest.GsmNumber = _gsmNumber;
            createSubMerchantRequest.Address = _address;
            createSubMerchantRequest.Iban = _iban;
            createSubMerchantRequest.TaxOffice = _taxOffice;
            createSubMerchantRequest.ContactName = _contactName;
            createSubMerchantRequest.ContactSurname = _contactSurname;
            createSubMerchantRequest.LegalCompanyTitle = _legalCompanyTitle;
            createSubMerchantRequest.SubMerchantExternalId =_subMerchantExternalId;
            createSubMerchantRequest.IdentityNumber = _identityNumber;
            createSubMerchantRequest.TaxNumber = _taxNumber;
            createSubMerchantRequest.SubMerchantType = _subMerchantType;
            createSubMerchantRequest.Currency =_currency;
            createSubMerchantRequest.SwiftCode = _swiftCode;
            return createSubMerchantRequest;
        }

        public CreateSubMerchantRequestBuilder PersonalSubMerchantRequest()
        {
            _subMerchantExternalId = RandomGenerator.RandomId;
            _subMerchantType = Model.SubMerchantType.PERSONAL.ToString();
            _contactName = "John";
            _contactSurname = "Doe";
            _identityNumber = "123456789";
            return this;
        }

        public CreateSubMerchantRequestBuilder PrivateSubMerchantRequest()
        {
            _subMerchantExternalId = RandomGenerator.RandomId;
            _subMerchantType = Model.SubMerchantType.PRIVATE_COMPANY.ToString();
            _taxOffice = "Tax office";
            _legalCompanyTitle = "John Doe inc";
            _identityNumber = "31300864726";
            return this;
        }

        public CreateSubMerchantRequestBuilder LimitedCompanySubMerchantRequest()
        {
            _subMerchantExternalId = RandomGenerator.RandomId;
            _subMerchantType = Model.SubMerchantType.LIMITED_OR_JOINT_STOCK_COMPANY.ToString();
            _taxOffice = "Tax office";
            _taxNumber = "9261877";
            _legalCompanyTitle = "XYZ inc";
            return this;
        }
    }
}
