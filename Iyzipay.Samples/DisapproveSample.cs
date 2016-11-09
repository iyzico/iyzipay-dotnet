using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class DisapproveSample : Sample
    {
        [Test]
        public void Should_Disapprove_Payment_Item()
        {
            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "1";

            Disapproval disapproval = Disapproval.Create(request, options);

            PrintResponse<Disapproval>(disapproval);

            Assert.AreEqual(Status.SUCCESS.ToString(), disapproval.Status);
            Assert.AreEqual(Locale.TR.ToString(), disapproval.Locale);
            Assert.AreEqual("123456789", disapproval.ConversationId);
            Assert.IsNotNull(disapproval.SystemTime);
            Assert.IsNull(disapproval.ErrorCode);
            Assert.IsNull(disapproval.ErrorMessage);
            Assert.IsNull(disapproval.ErrorGroup);
        }
    }
}
