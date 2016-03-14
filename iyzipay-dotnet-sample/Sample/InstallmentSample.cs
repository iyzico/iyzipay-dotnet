using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class InstallmentSample : Sample
    {
        [TestMethod]
        public void Should_Retrieve_Installment_Info()
        {
            RetrieveInstallmentInfoRequest request = new RetrieveInstallmentInfoRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BinNumber = "454671";
            request.Price = "1";

            InstallmentInfo installmentInfo = InstallmentInfo.Retrieve(request, options);

            PrintResponse<InstallmentInfo>(installmentInfo);

            Assert.IsNotNull(installmentInfo.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), installmentInfo.Status);
            Assert.AreEqual(Locale.TR.GetName(), installmentInfo.Locale);
            Assert.AreEqual("123456789", installmentInfo.ConversationId);
        }

        [TestMethod]
        public void Should_Retrieve_Installment_Info_For_All_Banks()
        {
            RetrieveInstallmentInfoRequest request = new RetrieveInstallmentInfoRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";        
            request.Price = "1";

            InstallmentInfo installmentInfo = InstallmentInfo.Retrieve(request, options);

            PrintResponse<InstallmentInfo>(installmentInfo);

            Assert.IsNotNull(installmentInfo.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), installmentInfo.Status);
            Assert.AreEqual(Locale.TR.GetName(), installmentInfo.Locale);
            Assert.AreEqual("123456789", installmentInfo.ConversationId);
        }
    }
}
