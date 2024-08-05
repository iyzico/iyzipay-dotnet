using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class CancelSample : Sample
    {
        [Test]
        public async Task Should_Cancel_PaymentAsync()
        {
            CreateCancelRequest request = new CreateCancelRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.ToString();
            request.PaymentId = "1";
            request.Ip = "85.34.78.112";

            Cancel cancel = await Cancel.Create(request, options);

            PrintResponse<Cancel>(cancel);

            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(Locale.TR.ToString(), cancel.Locale);
            Assert.AreEqual("123456789", cancel.ConversationId);
            Assert.IsNotNull(cancel.SystemTime);
            Assert.IsNull(cancel.ErrorMessage);
        }

        [Test]
        public async Task Should_Cancel_Payment_With_Reason_And_DescriptionAsync()
        {
            CreateCancelRequest request = new CreateCancelRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.ToString();
            request.PaymentId = "1";
            request.Ip = "85.34.78.112";
            request.Reason = RefundReason.OTHER.ToString();
            request.Description = "customer requested for default sample";

            Cancel cancel = await Cancel.Create(request, options);

            PrintResponse<Cancel>(cancel);

            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(Locale.TR.ToString(), cancel.Locale);
            Assert.AreEqual("123456789", cancel.ConversationId);
            Assert.IsNotNull(cancel.SystemTime);
            Assert.IsNull(cancel.ErrorMessage);
        }
    }
}
