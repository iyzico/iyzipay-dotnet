using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class RetrievePayoutTransactionsTest : BaseTest
    {
        [Test]
        public async Task Should_Retrieve_Payout_Completed_TransactionsAsync()
        {
            RetrieveTransactionsRequest request = new RetrieveTransactionsRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Date = "2016-01-22 19:13:00";

            PayoutCompletedTransactionList payoutCompletedTransactionList = await PayoutCompletedTransactionList.Retrieve(request, _options);

            PrintResponse(payoutCompletedTransactionList);

            Assert.AreEqual(Status.SUCCESS.ToString(), payoutCompletedTransactionList.Status);
            Assert.AreEqual(Locale.TR.ToString(), payoutCompletedTransactionList.Locale);
            Assert.AreEqual("123456789", payoutCompletedTransactionList.ConversationId);
            Assert.NotNull(payoutCompletedTransactionList.SystemTime);
            Assert.Null(payoutCompletedTransactionList.ErrorMessage);
        }

        [Test]
        public async Task Should_Retrieve_Bounced_Bank_TransfersAsync()
        {
            RetrieveTransactionsRequest request = new RetrieveTransactionsRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Date = "2016-01-22 19:13:00";

            BouncedBankTransferList bouncedBankTransferList = await BouncedBankTransferList.Retrieve(request, _options);

            PrintResponse(bouncedBankTransferList);

            Assert.AreEqual(Status.SUCCESS.ToString(), bouncedBankTransferList.Status);
            Assert.AreEqual(Locale.TR.ToString(), bouncedBankTransferList.Locale);
            Assert.AreEqual("123456789", bouncedBankTransferList.ConversationId);
            Assert.NotNull(bouncedBankTransferList.SystemTime);
            Assert.Null(bouncedBankTransferList.ErrorMessage);
        }
    }
}
