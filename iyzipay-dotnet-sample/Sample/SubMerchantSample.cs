using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace iyzipay_dotnet_sample.Sample
{
    [TestClass]
    public class SubMerchantSample : Sample
    {
        [TestMethod]
        public void Should_Create_Personal_Sub_Merchant()
        {
            CreateSubMerchantRequest request = new CreateSubMerchantRequest();
            request.ConversationId = "123456";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantExternalId = "B49224";
            request.SubMerchantType = SubMerchantType.PERSONAL.ToString();
            request.Address = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy 34732";
            request.ContactName = "Sabri Onur";
            request.ContactSurname = "Tüzün";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Sabri Onur'un mağazası";
            request.Iban = "TR180006200119000006672315";
            request.IdentityNumber = "1234567890";

            SubMerchant subMerchant = SubMerchant.Create(request, options);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        [TestMethod]
        public void Should_Create_Private_Sub_Merchant()
        {
            CreateSubMerchantRequest request = new CreateSubMerchantRequest();
            request.ConversationId = "123456";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantExternalId = "S49222";
            request.SubMerchantType = SubMerchantType.PRIVATE_COMPANY.ToString();
            request.Address = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy 34732";
            request.TaxOffice = "Kadıköy V.D.";
            request.LegalCompanyTitle = "Sabri Onur Tüzün Bilişim Hizmetleri";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Sabri Onur'un mağazası";
            request.Iban = "TR180006200119000006672315";
            request.IdentityNumber = "31300864726";

            SubMerchant subMerchant = SubMerchant.Create(request, options);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        [TestMethod]
        public void Should_Create_Limited_Company_Sub_Merchant()
        {
            CreateSubMerchantRequest request = new CreateSubMerchantRequest();
            request.ConversationId = "123456";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantExternalId = "AS49224";
            request.SubMerchantType = SubMerchantType.LIMITED_OR_JOINT_STOCK_COMPANY.ToString();
            request.Address = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy 34732";
            request.TaxOffice = "Kadıköy V.D.";
            request.TaxNumber = "9261877";
            request.LegalCompanyTitle = "XYZ Bilişim Hizmetleri A.Ş.";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Sabri Onur'un mağazası";
            request.Iban = "TR180006200119000006672315";

            SubMerchant subMerchant = SubMerchant.Create(request, options);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        [TestMethod]
        public void Should_Update_Personal_Sub_Merchant()
        {
            UpdateSubMerchantRequest request = new UpdateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantKey = "y3XZJBW9Sx2h2UZXgL6VMJbPCZY=";
            request.Address = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy 34732";
            request.ContactName = "Hakan";
            request.ContactSurname = "Erdoğan";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Hakan Erdoğan'ın mağazası";
            request.Iban = "TR630006200027700006678204";
            request.IdentityNumber = "31300864726";

            SubMerchant subMerchant = SubMerchant.Update(request, options);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        [TestMethod]
        public void Should_Update_Private_Sub_Merchant()
        {
            UpdateSubMerchantRequest request = new UpdateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantKey = "sub merchant key";
            request.Address = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy 34732";
            request.TaxOffice = "Kadıköy V.D.";
            request.LegalCompanyTitle = "Hakan Erdoğan Bilişim Hizmetleri";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Hakan Erdoğan'ın mağazası";
            request.Iban = "TR180006200119000006672315";
            request.IdentityNumber = "31300864726";

            SubMerchant subMerchant = SubMerchant.Update(request, options);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        [TestMethod]
        public void Should_Update_Limited_Company_Sub_Merchant()
        {
            UpdateSubMerchantRequest request = new UpdateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantKey = "B7PfwgaGY/pdNVZBRrfArqxHjUQ=";
            request.Address = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy 34732";
            request.TaxOffice = "Kadıköy V.D.";
            request.TaxNumber = "9261877";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Hakan Erdoğan'ın mağazası";
            request.Iban = "TR180006200119000006672315";

            SubMerchant subMerchant = SubMerchant.Update(request, options);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        [TestMethod]
        public void Should_Retrieve_Sub_Merchant()
        {
            RetrieveSubMerchantRequest request = new RetrieveSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantExternalId = "AS49224";

            SubMerchant subMerchant = SubMerchant.Retrieve(request, options);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }
    }
}
