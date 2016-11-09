using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;

namespace Iyzipay.Samples
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
    }
}
