using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;

namespace IyzipaySample.Sample
{
    public class InstallmentSample : Sample
    {
        [Test]
        public void Should_Retrieve_Installments()
        {
            RetrieveInstallmentInfoRequest request = new RetrieveInstallmentInfoRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BinNumber = "554960";
            request.Price = "100";

            InstallmentInfo installmentInfo = InstallmentInfo.Retrieve(request, options);

            PrintResponse<InstallmentInfo>(installmentInfo);

            Assert.IsNotNull(installmentInfo.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), installmentInfo.Status);
            Assert.AreEqual(Locale.TR.GetName(), installmentInfo.Locale);
            Assert.AreEqual("123456789", installmentInfo.ConversationId);
        }
    }
}
