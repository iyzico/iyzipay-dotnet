using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class BinNumberTest : BaseTest
    {
        [Test]
        public void Should_Retrieve_Bin()
        {
            RetrieveBinNumberRequest request = RetrieveBinNumberRequestBuilder.Create()
                .BinNumber("554960")
                .Build();

            BinNumber binNumber = BinNumber.Retrieve(request, _options);

            PrintResponse(request);

            Assert.AreEqual(Status.SUCCESS.ToString(), binNumber.Status);
            Assert.AreEqual(Locale.TR.ToString(), binNumber.Locale);
            Assert.AreEqual("123456789", binNumber.ConversationId);
            Assert.NotNull(binNumber.SystemTime);
            Assert.Null(binNumber.ErrorCode);
            Assert.Null(binNumber.ErrorMessage);
            Assert.Null(binNumber.ErrorGroup);
            Assert.AreEqual("554960", binNumber.Bin);
            Assert.AreEqual("CREDIT_CARD", binNumber.CardType);
            Assert.AreEqual("MASTER_CARD", binNumber.CardAssociation);
            Assert.AreEqual("Bonus", binNumber.CardFamily);
            Assert.AreEqual("Garanti Bankası", binNumber.BankName);
            Assert.AreEqual(62, binNumber.BankCode);
        }
    }
}
