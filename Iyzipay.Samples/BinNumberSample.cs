using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class BinNumberSample : Sample
    {
        [Test]
        public async Task Should_Retrieve_Bin_NumberAsync()
        {
            RetrieveBinNumberRequest request = new RetrieveBinNumberRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.BinNumber = "554960";

            BinNumber binNumber = await BinNumber.Retrieve(request, options);

            PrintResponse<BinNumber>(binNumber);

            Assert.AreEqual(Status.SUCCESS.ToString(), binNumber.Status);
            Assert.AreEqual(Locale.TR.ToString(), binNumber.Locale);
            Assert.AreEqual("123456789", binNumber.ConversationId);
            Assert.IsNotNull(binNumber.SystemTime);
            Assert.IsNull(binNumber.ErrorCode);
            Assert.IsNull(binNumber.ErrorMessage);
            Assert.IsNull(binNumber.ErrorGroup);
            Assert.AreEqual("554960", binNumber.Bin);
            Assert.AreEqual("CREDIT_CARD", binNumber.CardType);
            Assert.AreEqual("MASTER_CARD", binNumber.CardAssociation);
            Assert.AreEqual("Bonus", binNumber.CardFamily);
            Assert.AreEqual("Garanti Bankası", binNumber.BankName);
            Assert.AreEqual(62, binNumber.BankCode);
        }
    }
}