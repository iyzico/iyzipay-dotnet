// <copyright file="BinNumberSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// BIN number sample
    /// </summary>
    /// <seealso cref="IyzipaySample.Sample.Sample" />
    /// <summary>
    /// BinNumberSample
    /// </summary>
    [TestClass]
    public class BinNumberSample : Sample
    {
        /// <summary>
        /// Should retrieve bin number.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveBinNumber()
        {
            var request = new RetrieveBinNumberRequest();
            request.BinNumber = "454671";
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();

            var binNumber = BinNumber.Retrieve(request, Options);

            this.PrintResponse<BinNumber>(binNumber);

            Assert.IsNotNull(binNumber.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), binNumber.Status);
            Assert.AreEqual(Locale.TR.GetName(), binNumber.Locale);
            Assert.AreEqual("123456789", binNumber.ConversationId);
            Assert.AreEqual("454671", binNumber.Bin);
            Assert.AreEqual("CREDITCARD", binNumber.CardType);
            Assert.AreEqual("VISA", binNumber.CardAssociation);
            Assert.AreEqual("Ziraat Bankası CC", binNumber.CardFamily);
            Assert.AreEqual("Ziraat Bankası", binNumber.BankName);
            Assert.AreEqual(10, binNumber.BankCode);
        }
    }
}