using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ConnectRefundSample : Sample
    {
        [TestMethod]
        public void Should_Refund_Payment()
        {
            CreateRefundRequest request = new CreateRefundRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "1";
            request.Price = "1.0";
            request.Ip = "85.34.78.112";
            request.Currency = Currency.TRY.ToString();

            ConnectRefund connectRefund = ConnectRefund.Create(request, options);

            PrintResponse<ConnectRefund>(connectRefund);

            Assert.IsNotNull(connectRefund.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectRefund.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectRefund.Locale);
            Assert.AreEqual("123456789", connectRefund.ConversationId);
        }
    }
}
