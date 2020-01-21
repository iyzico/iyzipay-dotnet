using Iyzipay.Model;
using Iyzipay.Model.V2;
using Iyzipay.Model.V2.Transaction;
using Iyzipay.Request.V2;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class TransactionReportSample : Sample
    {
        [Test]
        public void Should_Retrieve_TransactionReport()
        {
            RetrieveTransactionReportRequest request = new RetrieveTransactionReportRequest()
            {
                ConversationId = "123",
                TransactionDate = "2018-06-28",
                Page = 1
            };

            TransactionReport transactionReport = TransactionReport.Retrieve(request, options);

            PrintResponse<TransactionReport>(transactionReport);

            Assert.AreEqual(Status.SUCCESS.ToString(), transactionReport.Status);
            Assert.AreEqual(200, transactionReport.StatusCode);
            Assert.AreEqual("123", transactionReport.ConversationId);
            Assert.AreEqual(1, transactionReport.CurrentPage);
            Assert.IsNotNull(transactionReport.TotalPageCount);
            Assert.IsNotNull(transactionReport.SystemTime);
            Assert.IsNull(transactionReport.ErrorMessage);
        }
    }
}
