using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class BinNumberTest : BaseTest
    {
        [Test]
        public async Task Should_Retrieve_BinAsync()
        {
            RetrieveBinNumberRequest request = RetrieveBinNumberRequestBuilder.Create()
                .BinNumber("554960")
                .Build();

            BinNumber binNumber = await BinNumber.Retrieve(request, _options);

            PrintResponse(request);

            Assert.AreEqual(Status.SUCCESS.ToString(), binNumber.Status);
            Assert.AreEqual(Locale.TR.ToString(), binNumber.Locale);
            Assert.AreEqual("123456789", binNumber.ConversationId);
            Assert.NotNull(binNumber.SystemTime);
            Assert.Null(binNumber.ErrorMessage);
            Assert.AreEqual("554960", binNumber.Bin);
            Assert.AreEqual("CREDIT_CARD", binNumber.CardType);
            Assert.AreEqual("MASTER_CARD", binNumber.CardAssociation);
            Assert.AreEqual("Bonus", binNumber.CardFamily);
            Assert.AreEqual("Garanti Bankası", binNumber.BankName);
            Assert.AreEqual(0, binNumber.Commercial);
            Assert.AreEqual(62, binNumber.BankCode);
        }
        
        [Test]
        public async Task Should_Retrieve_Bin_With_Commercial_OneAsync()
        {
            RetrieveBinNumberRequest request = RetrieveBinNumberRequestBuilder.Create()
                .BinNumber("552659")
                .Build();

            BinNumber binNumber = await BinNumber.Retrieve(request, _options);

            PrintResponse(request);

            Assert.AreEqual(Status.SUCCESS.ToString(), binNumber.Status);
            Assert.AreEqual(Locale.TR.ToString(), binNumber.Locale);
            Assert.AreEqual("123456789", binNumber.ConversationId);
            Assert.NotNull(binNumber.SystemTime);
            Assert.Null(binNumber.ErrorMessage);
            Assert.AreEqual("552659", binNumber.Bin);
            Assert.AreEqual("CREDIT_CARD", binNumber.CardType);
            Assert.AreEqual("MASTER_CARD", binNumber.CardAssociation);
            Assert.AreEqual("World", binNumber.CardFamily);
            Assert.AreEqual("Yapı Kredi Bankası", binNumber.BankName);
            Assert.AreEqual(1, binNumber.Commercial);
            Assert.AreEqual(67, binNumber.BankCode);
        }
    }
    
    
}
