using Iyzpay.NetCore.Model;
using Iyzpay.NetCore.Request;
using NUnit.Framework;

namespace Iyzipay.NetCore.Tests
{
    public class CancelSample : Sample
    {
        [Test]
        public void Should_Cancel_Payment()
        {
            CreateCancelRequest request = new CreateCancelRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.ToString();
            request.PaymentId = "1";
            request.Ip = "85.34.78.112";

            Cancel cancel = Cancel.Create(request, options);

            PrintResponse<Cancel>(cancel);

            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(Locale.TR.ToString(), cancel.Locale);
            Assert.AreEqual("123456789", cancel.ConversationId);
            Assert.IsNotNull(cancel.SystemTime);
            Assert.IsNull(cancel.ErrorCode);
            Assert.IsNull(cancel.ErrorMessage);
            Assert.IsNull(cancel.ErrorGroup);
        }

        [Test]
        public void Should_Cancel_Payment_With_Reason_And_Description()
        {
            CreateCancelRequest request = new CreateCancelRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.ToString();
            request.PaymentId = "1";
            request.Ip = "85.34.78.112";
            request.Reason = RefundReason.OTHER.ToString();
            request.Description = "customer requested for default sample";

            Cancel cancel = Cancel.Create(request, options);

            PrintResponse<Cancel>(cancel);

            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(Locale.TR.ToString(), cancel.Locale);
            Assert.AreEqual("123456789", cancel.ConversationId);
            Assert.IsNotNull(cancel.SystemTime);
            Assert.IsNull(cancel.ErrorCode);
            Assert.IsNull(cancel.ErrorMessage);
            Assert.IsNull(cancel.ErrorGroup);
        }
    }
}
