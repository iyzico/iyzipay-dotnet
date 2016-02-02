using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace iyzipay_dotnet_sample.Sample
{
    [TestClass]
    public class RetrieveTransactionsSample : Sample
    {
        [TestMethod]
        public void Should_Retrieve_Payout_Completed_Transactions()
        {
            RetrieveTransactionsRequest request = new RetrieveTransactionsRequest();
            request.ConversationId = "123456";
            request.Locale = Locale.TR.GetName();
            request.Date = "2016-01-22 19:13:00";

            PayoutCompletedTransactionList payoutCompletedTransactionList = PayoutCompletedTransactionList.Retrieve(request, options);

            Assert.IsNotNull(payoutCompletedTransactionList.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), payoutCompletedTransactionList.Status);
            Assert.AreEqual(Locale.TR.GetName(), payoutCompletedTransactionList.Locale);
            Assert.AreEqual("123456789", payoutCompletedTransactionList.ConversationId);
        }

        [TestMethod]
        public void Should_Retrieve_Bounced_Bank_Transfers()
        {
            RetrieveTransactionsRequest request = new RetrieveTransactionsRequest();
            request.ConversationId = "123456";
            request.Locale = Locale.TR.GetName();
            request.Date = "2015-06-02 19:13:00";

            BouncedBankTransferList bouncedBankTransferList = BouncedBankTransferList.Retrieve(request, options);
            Assert.IsNotNull(bouncedBankTransferList.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bouncedBankTransferList.Status);
            Assert.AreEqual(Locale.TR.GetName(), bouncedBankTransferList.Locale);
            Assert.AreEqual("123456789", bouncedBankTransferList.ConversationId);
        }
    }
}
