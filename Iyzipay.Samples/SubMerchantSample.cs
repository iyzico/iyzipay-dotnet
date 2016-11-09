using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class SubMerchantSample : Sample
    {
        [Test]
        public void Should_Create_Personal_Sub_Merchant()
        {
            CreateSubMerchantRequest request = new CreateSubMerchantRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantExternalId = "B49224";
            request.SubMerchantType = SubMerchantType.PERSONAL.ToString();
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.ContactName = "John";
            request.ContactSurname = "Doe";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "John's market";
            request.Iban = "TR180006200119000006672315";
            request.IdentityNumber = "31300864726";
            request.Currency = Currency.TRY.ToString();

            SubMerchant subMerchant = SubMerchant.Create(request, options);

            PrintResponse<SubMerchant>(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.IsNull(subMerchant.ErrorCode);
            Assert.IsNull(subMerchant.ErrorMessage);
            Assert.IsNull(subMerchant.ErrorGroup);
        }

        [Test]
        public void Should_Create_Private_Sub_Merchant()
        {
            CreateSubMerchantRequest request = new CreateSubMerchantRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantExternalId = "S49222";
            request.SubMerchantType = SubMerchantType.PRIVATE_COMPANY.ToString();
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.TaxOffice = "Tax office";
            request.LegalCompanyTitle = "John Doe inc";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "John's market";
            request.Iban = "TR180006200119000006672315";
            request.IdentityNumber = "31300864726";
            request.Currency = Currency.TRY.ToString();

            SubMerchant subMerchant = SubMerchant.Create(request, options);

            PrintResponse<SubMerchant>(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.IsNull(subMerchant.ErrorCode);
            Assert.IsNull(subMerchant.ErrorMessage);
            Assert.IsNull(subMerchant.ErrorGroup);
        }

        [Test]
        public void Should_Create_Limited_Company_Sub_Merchant()
        {
            CreateSubMerchantRequest request = new CreateSubMerchantRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantExternalId = "AS49224";
            request.SubMerchantType = SubMerchantType.LIMITED_OR_JOINT_STOCK_COMPANY.ToString();
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.TaxOffice = "Tax office";
            request.TaxNumber = "9261877";
            request.LegalCompanyTitle = "XYZ inc";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "John's market";
            request.Iban = "TR180006200119000006672315";
            request.Currency = Currency.TRY.ToString();

            SubMerchant subMerchant = SubMerchant.Create(request, options);

            PrintResponse<SubMerchant>(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.IsNull(subMerchant.ErrorCode);
            Assert.IsNull(subMerchant.ErrorMessage);
            Assert.IsNull(subMerchant.ErrorGroup);
        }

        [Test]
        public void Should_Update_Personal_Sub_Merchant()
        {
            UpdateSubMerchantRequest request = new UpdateSubMerchantRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "sub merchant key";
            request.Iban = "TR630006200027700006678204";
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.ContactName = "Jane";
            request.ContactSurname = "Doe";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Jane's market";
            request.IdentityNumber = "31300864726";
            request.Currency = Currency.TRY.ToString();

            SubMerchant subMerchant = SubMerchant.Update(request, options);

            PrintResponse<SubMerchant>(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.IsNull(subMerchant.ErrorCode);
            Assert.IsNull(subMerchant.ErrorMessage);
            Assert.IsNull(subMerchant.ErrorGroup);
        }

        [Test]
        public void Should_Update_Private_Sub_Merchant()
        {
            UpdateSubMerchantRequest request = new UpdateSubMerchantRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "sub merchant key";
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.TaxOffice = "Tax office";
            request.LegalCompanyTitle = "Jane Doe inc";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Jane's market";
            request.Iban = "TR180006200119000006672315";
            request.IdentityNumber = "31300864726";
            request.Currency = Currency.TRY.ToString();

            SubMerchant subMerchant = SubMerchant.Update(request, options);

            PrintResponse<SubMerchant>(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.IsNull(subMerchant.ErrorCode);
            Assert.IsNull(subMerchant.ErrorMessage);
            Assert.IsNull(subMerchant.ErrorGroup);
        }

        [Test]
        public void Should_Update_Limited_Company_Sub_Merchant()
        {
            UpdateSubMerchantRequest request = new UpdateSubMerchantRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "sub merchant key";
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.TaxOffice = "Tax office";
            request.TaxNumber = "9261877";
            request.LegalCompanyTitle = "ABC inc";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Jane's market";
            request.Iban = "TR180006200119000006672315";
            request.Currency = Currency.TRY.ToString();

            SubMerchant subMerchant = SubMerchant.Update(request, options);

            PrintResponse<SubMerchant>(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.IsNull(subMerchant.ErrorCode);
            Assert.IsNull(subMerchant.ErrorMessage);
            Assert.IsNull(subMerchant.ErrorGroup);
        }

        [Test]
        public void Should_Retrieve_Sub_Merchant()
        {
            RetrieveSubMerchantRequest request = new RetrieveSubMerchantRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantExternalId = "AS49224";

            SubMerchant subMerchant = SubMerchant.Retrieve(request, options);

            PrintResponse<SubMerchant>(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.IsNull(subMerchant.ErrorCode);
            Assert.IsNull(subMerchant.ErrorMessage);
            Assert.IsNull(subMerchant.ErrorGroup);
        }
    }
}
