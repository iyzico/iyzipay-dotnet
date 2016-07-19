// <copyright file="InstallmentSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Installment sample
    /// </summary>
    [TestClass]
    public class InstallmentSample : Sample
    {
        /// <summary>
        /// Should retrieve installment information.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveInstallmentInfo()
        {
            var request = new RetrieveInstallmentInfoRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BinNumber = "454671";
            request.Price = "1";

            var installmentInfo = InstallmentInfo.Retrieve(request, Options);

            this.PrintResponse<InstallmentInfo>(installmentInfo);

            Assert.IsNotNull(installmentInfo.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), installmentInfo.Status);
            Assert.AreEqual(Locale.TR.GetName(), installmentInfo.Locale);
            Assert.AreEqual("123456789", installmentInfo.ConversationId);
        }

        /// <summary>
        /// Should retrieve installment information for all banks.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveInstallmentInfoForAllBanks()
        {
            var request = new RetrieveInstallmentInfoRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";

            var installmentInfo = InstallmentInfo.Retrieve(request, Options);

            this.PrintResponse<InstallmentInfo>(installmentInfo);

            Assert.IsNotNull(installmentInfo.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), installmentInfo.Status);
            Assert.AreEqual(Locale.TR.GetName(), installmentInfo.Locale);
            Assert.AreEqual("123456789", installmentInfo.ConversationId);
        }
    }
}
