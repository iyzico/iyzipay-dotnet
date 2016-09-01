using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;

namespace IyzipaySample.Sample
{
    public class BinNumberSample : Sample
    {
        [Test]
        public void Should_Retrieve_Bin_Number()
        {
            RetrieveBinNumberRequest request = new RetrieveBinNumberRequest();
            request.BinNumber = "554960";
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();

            BinNumber binNumber = BinNumber.Retrieve(request, options);

            PrintResponse<BinNumber>(binNumber);

            Assert.IsNotNull(binNumber.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), binNumber.Status);
            Assert.AreEqual(Locale.TR.GetName(), binNumber.Locale);
            Assert.AreEqual("123456789", binNumber.ConversationId);
            Assert.AreEqual("554960", binNumber.Bin);
            Assert.AreEqual("CREDIT_CARD", binNumber.CardType);
            Assert.AreEqual("MASTER_CARD", binNumber.CardAssociation);
            Assert.AreEqual("Bonus", binNumber.CardFamily);
            Assert.AreEqual("Garanti Bankası", binNumber.BankName);
            Assert.AreEqual(62, binNumber.BankCode);
        }
    }
}