using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class DisapproveSample : Sample
    {
        [TestMethod]
        public void Should_Disapprove_Payment_Item()
        {
            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "1";

            Disapproval disapproval = Disapproval.Create(request, options);

            PrintResponse<Disapproval>(disapproval);

            Assert.IsNotNull(disapproval.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), disapproval.Status);
            Assert.AreEqual(Locale.TR.GetName(), disapproval.Locale);
            Assert.AreEqual("123456789", disapproval.ConversationId);
            Assert.AreEqual("1", disapproval.PaymentTransactionId);
        }
    }
}
