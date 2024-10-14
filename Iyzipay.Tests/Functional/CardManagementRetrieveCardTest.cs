using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class CardManagementRetrieveCardTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _options.BaseUrl = "https://sandbox-cm.iyzipay.com";
        }

        [Test]
        public async Task Should_Retrieve_CardsAsync()
        {
            CreateCardManagementPageInitializeRequest initializeRequest = CardManagementPageRequestBuilder.Create().Build();
            CardManagementPageInitialize cardManagementPageInitialize = CardManagementPageInitialize.Create(initializeRequest, _options);
            
            RetrieveCardManagementPageCardRequest retrieveCardRequest = CardManagementRetrieveCardBuilder.Create()
                .PageToken(cardManagementPageInitialize.Token)
                .Build();
            
            CardManagementPageCard cardManagementPageCard = CardManagementPageCard.Retrieve(retrieveCardRequest, _options);
            PrintResponse(cardManagementPageCard);

            Assert.AreEqual(Status.SUCCESS.ToString(), cardManagementPageCard.Status);
            Assert.AreEqual(Locale.TR.ToString(), cardManagementPageCard.Locale);
            Assert.Null(cardManagementPageCard.ErrorMessage);
            Assert.NotNull(cardManagementPageCard);
        }
        
        [Test]
        public void Should_Not_Retrieve_Cards_When_PageToken_Is_Not_Exist()
        {
            RetrieveCardManagementPageCardRequest retrieveCardRequest = CardManagementRetrieveCardBuilder.Create()
                .PageToken("pagetoken")
                .Build();
            
            CardManagementPageCard cardManagementPageCard = CardManagementPageCard.Retrieve(retrieveCardRequest, _options);
            PrintResponse(cardManagementPageCard);

            Assert.AreEqual(Status.FAILURE.ToString(), cardManagementPageCard.Status);
            Assert.AreEqual("Geçersiz token",cardManagementPageCard.ErrorMessage);
        }
    }
}