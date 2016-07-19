// <copyright file="SubMerchantSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Sub-merchant sample
    /// </summary>
    [TestClass]
    public class SubMerchantSample : Sample
    {
        /// <summary>
        /// Should create personal sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldCreatePersonalSubMerchant()
        {
            var request = new CreateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantExternalId = "B49224";
            request.SubMerchantType = SubMerchantType.PERSONAL.ToString();
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.ContactName = "John";
            request.ContactSurname = "Doe";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "John's market";
            request.Iban = "TR180006200119000006672315";
            request.IdentityNumber = "1234567890";
            request.Currency = Currency.TRY.ToString();

            var subMerchant = SubMerchant.Create(request, Options);

            this.PrintResponse<SubMerchant>(subMerchant);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        /// <summary>
        /// Should create private sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldCreatePrivateSubMerchant()
        {
            var request = new CreateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
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

            var subMerchant = SubMerchant.Create(request, Options);

            this.PrintResponse<SubMerchant>(subMerchant);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        /// <summary>
        /// Should create limited company sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldCreateLimitedCompanySubMerchant()
        {
            var request = new CreateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
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

            var subMerchant = SubMerchant.Create(request, Options);

            this.PrintResponse<SubMerchant>(subMerchant);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        /// <summary>
        /// Should update personal sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldUpdatePersonalSubMerchant()
        {
            var request = new UpdateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantKey = "sub merchant key";
            request.Address = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            request.ContactName = "Jane";
            request.ContactSurname = "Doe";
            request.Email = "email@submerchantemail.com";
            request.GsmNumber = "+905350000000";
            request.Name = "Jane's market";
            request.Iban = "TR630006200027700006678204";
            request.IdentityNumber = "31300864726";
            request.Currency = Currency.TRY.ToString();

            var subMerchant = SubMerchant.Update(request, Options);

            this.PrintResponse<SubMerchant>(subMerchant);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        /// <summary>
        /// Should update private sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldUpdatePrivateSubMerchant()
        {
            var request = new UpdateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
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

            var subMerchant = SubMerchant.Update(request, Options);

            this.PrintResponse<SubMerchant>(subMerchant);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        /// <summary>
        /// Should update limited company sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldUpdateLimitedCompanySubMerchant()
        {
            var request = new UpdateSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
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

            var subMerchant = SubMerchant.Update(request, Options);

            this.PrintResponse<SubMerchant>(subMerchant);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }

        /// <summary>
        /// Should retrieve sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveSubMerchant()
        {
            var request = new RetrieveSubMerchantRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.SubMerchantExternalId = "AS49224";

            var subMerchant = SubMerchant.Retrieve(request, Options);

            this.PrintResponse<SubMerchant>(subMerchant);

            Assert.IsNotNull(subMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
        }
    }
}
