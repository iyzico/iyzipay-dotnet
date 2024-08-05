using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class DisapproveSample : Sample
    {
        [Test]
        public async Task Should_Disapprove_Payment_ItemAsync()
        {
            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "1";

            Disapproval disapproval = await Disapproval.Create(request, options);

            PrintResponse<Disapproval>(disapproval);

            Assert.AreEqual(Status.SUCCESS.ToString(), disapproval.Status);
            Assert.AreEqual(Locale.TR.ToString(), disapproval.Locale);
            Assert.AreEqual("123456789", disapproval.ConversationId);
            Assert.IsNotNull(disapproval.SystemTime);
            Assert.IsNull(disapproval.ErrorMessage);
        }
    }
}
