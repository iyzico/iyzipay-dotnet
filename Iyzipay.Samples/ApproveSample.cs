using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class ApproveSample : Sample
    {
        [Test]
        public async Task Should_Approve_Payment_ItemAsync()
        {
            CreateApprovalRequest request = new CreateApprovalRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "1";

            Approval approval = await Approval.Create(request, options);

            PrintResponse<Approval>(approval);

            Assert.AreEqual(Status.SUCCESS.ToString(), approval.Status);
            Assert.AreEqual(Locale.TR.ToString(), approval.Locale);
            Assert.AreEqual("123456789", approval.ConversationId);
            Assert.IsNotNull(approval.SystemTime);
            Assert.IsNull(approval.ErrorCode);
            Assert.IsNull(approval.ErrorMessage);
            Assert.IsNull(approval.ErrorGroup);
        }
    }
}
