using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace iyzipay_dotnet_sample.Sample
{
    [TestClass]
    public class BinNumberSample : Sample
    {
        [TestMethod]
        public void Should_Retrieve_Bin_Number()
        {
            RetrieveBinNumberRequest request = new RetrieveBinNumberRequest();
            request.BinNumber = "454671";
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();

            BinNumber binNumber = BinNumber.Retrieve(request, options);

            PrintResponse<BinNumber>(binNumber);

            Assert.IsNotNull(binNumber.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), binNumber.Status);
            Assert.AreEqual(Locale.TR.GetName(), binNumber.Locale);
            Assert.AreEqual("123456789", binNumber.ConversationId);
            Assert.AreEqual("454671", binNumber.Bin);
            Assert.AreEqual("CREDIT_CARD", binNumber.CardType);
            Assert.AreEqual("VISA", binNumber.CardAssociation);
            Assert.AreEqual("Ziraat Bankası CC", binNumber.CardFamily);
            Assert.AreEqual("Ziraat Bankası", binNumber.BankName);
            Assert.AreEqual(10, binNumber.BankCode);
        }
    }
}