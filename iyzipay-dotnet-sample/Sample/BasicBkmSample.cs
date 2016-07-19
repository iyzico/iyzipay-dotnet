// <copyright file="BasicBkmSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using System.Collections.Generic;
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Basic BKM sample
    /// </summary>
    /// <seealso cref="IyzipaySample.Sample.Sample" />
    /// <summary>
    /// BasicBkmSample
    /// </summary>
    [TestClass]
    public class BasicBkmSample : Sample
    {
        /// <summary>
        /// Should initialize BKM express.
        /// </summary>
        [TestMethod]
        public void ShouldInitializeBkmExpress()
        {
            var request = new CreateBasicBkmInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";

            // prepare buyer
            request.BuyerId = "100";
            request.BuyerEmail = "email@email.com";
            request.BuyerIp = "85.34.78.112";

            // default pos
            request.ConnectorName = "connector name";
            request.InstallmentDetails = this.PrepareInstallmentDetails();
            var bkmInitialize = BasicBkmInitialize.Create(request, Options);

            this.PrintResponse<BasicBkmInitialize>(bkmInitialize);

            Assert.IsNotNull(bkmInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmInitialize.Locale);
            Assert.AreEqual("123456789", bkmInitialize.ConversationId);
            Assert.IsNotNull(bkmInitialize.HtmlContent);
        }

        /// <summary>
        /// Should retrieve BKM authentication.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveBkmAuth()
        {
            var request = new RetrieveBkmRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Token = "token";

            var basicBkm = BasicBkm.Retrieve(request, Options);

            this.PrintResponse<BasicBkm>(basicBkm);

            Assert.IsNotNull(basicBkm.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicBkm.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicBkm.Locale);
            Assert.AreEqual("123456789", basicBkm.ConversationId);
        }

        /// <summary>
        /// Prepares the installment details.
        /// </summary>
        /// <returns>The installment details</returns>
        private List<BkmInstallment> PrepareInstallmentDetails()
        {
            var installmentDetails = new List<BkmInstallment>();
            installmentDetails.Add(this.IsBankInstallmentDetails());
            installmentDetails.Add(this.FinansBankInstallmentDetails());
            installmentDetails.Add(this.AkBankInstallmentDetails());
            installmentDetails.Add(this.YkbInstallmentDetails());
            installmentDetails.Add(this.DenizBankInstallmentDetails());
            installmentDetails.Add(this.HalkBankInstallmentDetails());
            return installmentDetails;
        }

        /// <summary>
        /// Determines whether [is bank installment details].
        /// </summary>
        /// <returns>The installment details</returns>
        private BkmInstallment IsBankInstallmentDetails()
        {
            var installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 64L;

            var installmentPrices = new List<BkmInstallmentPrice>();

            var singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            var twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            var threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            var sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            var nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        /// <summary>
        /// FINANS bank installment details.
        /// </summary>
        /// <returns>The installment details</returns>
        private BkmInstallment FinansBankInstallmentDetails()
        {
            var installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 111L;

            var installmentPrices = new List<BkmInstallmentPrice>();

            var singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            var twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            var threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            var sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            var nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        /// <summary>
        /// AKS bank installment details.
        /// </summary>
        /// <returns>The installment details</returns>
        private BkmInstallment AkBankInstallmentDetails()
        {
            var installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 46L;

            var installmentPrices = new List<BkmInstallmentPrice>();

            var singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            var twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            var threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            var sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            var nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        /// <summary>
        /// YKBS the installment details.
        /// </summary>
        /// <returns>The installment details</returns>
        private BkmInstallment YkbInstallmentDetails()
        {
            var installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 67L;

            var installmentPrices = new List<BkmInstallmentPrice>();

            var singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            var twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            var threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            var sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            var nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        /// <summary>
        /// DENIZ bank installment details.
        /// </summary>
        /// <returns>The installment details</returns>
        private BkmInstallment DenizBankInstallmentDetails()
        {
            var installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 134L;

            var installmentPrices = new List<BkmInstallmentPrice>();

            var singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            var twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            var threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            var sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            var nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        /// <summary>
        /// HALK bank installment details.
        /// </summary>
        /// <returns>The installment details</returns>
        private BkmInstallment HalkBankInstallmentDetails()
        {
            var installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 12L;

            var installmentPrices = new List<BkmInstallmentPrice>();

            var singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            var twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            var threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            var sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            var nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }
    }
}
