// <copyright file="RetrieveTransactionsSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Retrieve transactions sample
    /// </summary>
    [TestClass]
    public class RetrieveTransactionsSample : Sample
    {
        /// <summary>
        /// Should retrieve payout completed transactions.
        /// </summary>
        [TestMethod]
        public void ShouldRetrievePayoutCompletedTransactions()
        {
            var request = new RetrieveTransactionsRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.Date = "2015-01-22 19:13:00";

            var payoutCompletedTransactionList = PayoutCompletedTransactionList.Retrieve(request, Options);

            this.PrintResponse<PayoutCompletedTransactionList>(payoutCompletedTransactionList);

            Assert.IsNotNull(payoutCompletedTransactionList.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), payoutCompletedTransactionList.Status);
            Assert.AreEqual(Locale.TR.GetName(), payoutCompletedTransactionList.Locale);
            Assert.AreEqual("123456789", payoutCompletedTransactionList.ConversationId);
        }

        /// <summary>
        /// Should retrieve bounced bank transfers.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveBouncedBankTransfers()
        {
            var request = new RetrieveTransactionsRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.Date = "2015-06-02 19:13:00";

            var bouncedBankTransferList = BouncedBankTransferList.Retrieve(request, Options);

            this.PrintResponse<BouncedBankTransferList>(bouncedBankTransferList);

            Assert.IsNotNull(bouncedBankTransferList.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bouncedBankTransferList.Status);
            Assert.AreEqual(Locale.TR.GetName(), bouncedBankTransferList.Locale);
            Assert.AreEqual("123456789", bouncedBankTransferList.ConversationId);
        }
    }
}
