using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class InstallmentSample : Sample
    {
        [Test]
        public void Should_Retrieve_Installments()
        {
            RetrieveInstallmentInfoRequest request = new RetrieveInstallmentInfoRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.BinNumber = "554960";
            request.Price = "100";

            InstallmentInfo installmentInfo = InstallmentInfo.Retrieve(request, options);

            PrintResponse<InstallmentInfo>(installmentInfo);

            Assert.AreEqual(Status.SUCCESS.ToString(), installmentInfo.Status);
            Assert.AreEqual(Locale.TR.ToString(), installmentInfo.Locale);
            Assert.AreEqual("123456789", installmentInfo.ConversationId);
            Assert.IsNotNull(installmentInfo.SystemTime);
            Assert.IsNull(installmentInfo.ErrorCode);
            Assert.IsNull(installmentInfo.ErrorMessage);
            Assert.IsNull(installmentInfo.ErrorGroup);
            Assert.IsNotNull(installmentInfo.InstallmentDetails);
            Assert.IsNotEmpty(installmentInfo.InstallmentDetails);
        }
    }
}
