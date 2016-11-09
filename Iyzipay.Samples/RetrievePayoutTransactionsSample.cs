using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class RetrievePayoutTransactionsSample : Sample
    {
        [Test]
        public void Should_Retrieve_Payout_Completed_Transactions()
        {
            RetrieveTransactionsRequest request = new RetrieveTransactionsRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Date = "2015-01-22 19:13:00";

            PayoutCompletedTransactionList payoutCompletedTransactionList = PayoutCompletedTransactionList.Retrieve(request, options);

            PrintResponse<PayoutCompletedTransactionList>(payoutCompletedTransactionList);

            Assert.AreEqual(Status.SUCCESS.ToString(), payoutCompletedTransactionList.Status);
            Assert.AreEqual(Locale.TR.ToString(), payoutCompletedTransactionList.Locale);
            Assert.AreEqual("123456789", payoutCompletedTransactionList.ConversationId);
            Assert.IsNotNull(payoutCompletedTransactionList.SystemTime);
            Assert.IsNull(payoutCompletedTransactionList.ErrorCode);
            Assert.IsNull(payoutCompletedTransactionList.ErrorMessage);
            Assert.IsNull(payoutCompletedTransactionList.ErrorGroup);
        }

        [Test]
        public void Should_Retrieve_Bounced_Bank_Transfers()
        {
            RetrieveTransactionsRequest request = new RetrieveTransactionsRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Date = "2015-06-02 19:13:00";

            BouncedBankTransferList bouncedBankTransferList = BouncedBankTransferList.Retrieve(request, options);

            PrintResponse<BouncedBankTransferList>(bouncedBankTransferList);

            Assert.AreEqual(Status.SUCCESS.ToString(), bouncedBankTransferList.Status);
            Assert.AreEqual(Locale.TR.ToString(), bouncedBankTransferList.Locale);
            Assert.AreEqual("123456789", bouncedBankTransferList.ConversationId);
            Assert.IsNotNull(bouncedBankTransferList.SystemTime);
            Assert.IsNull(bouncedBankTransferList.ErrorCode);
            Assert.IsNull(bouncedBankTransferList.ErrorMessage);
            Assert.IsNull(bouncedBankTransferList.ErrorGroup);
        }
    }
}
