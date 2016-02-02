using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace iyzipay_dotnet_sample.Sample
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
            request.PaymentTransactionId = "2";

            Approval approval = Approval.Create(request, options);
            Assert.IsNotNull(approval.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), approval.Status);
            Assert.AreEqual(Locale.TR.GetName(), approval.Locale);
            Assert.AreEqual("123456789", approval.ConversationId);
            Assert.AreEqual("2", approval.PaymentTransactionId);
        }

        [TestMethod]
        public void Should_Disapprove_Payment_Item()
        {
            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "2";

            Disapproval disapproval = Disapproval.Create(request, options);
            Assert.IsNotNull(disapproval.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), disapproval.Status);
            Assert.AreEqual(Locale.TR.GetName(), disapproval.Locale);
            Assert.AreEqual("123456789", disapproval.ConversationId);
            Assert.AreEqual("2", disapproval.PaymentTransactionId);
        }
    }
}
