using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ApprovalSample : Sample
    {
        [TestMethod]
        public void Should_Approve_Payment_Item()
        {
            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "1";

            Approval approval = Approval.Create(request, options);

            PrintResponse<Approval>(approval);

            Assert.IsNotNull(approval.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), approval.Status);
            Assert.AreEqual(Locale.TR.GetName(), approval.Locale);
            Assert.AreEqual("123456789", approval.ConversationId);
            Assert.AreEqual("1", approval.PaymentTransactionId);
        }
    }
}
