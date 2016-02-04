using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Model;
using Iyzipay.Request;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class CardStorageSample : Sample
    {
        [TestMethod]
        public void Should_Create_User_And_Add_Card()
        {
            CardInformation cardInformation = new CardInformation();
            cardInformation.CardAlias = "myAlias";
            cardInformation.CardHolderName = "John Doe";
            cardInformation.CardNumber = "5528790000000008";
            cardInformation.ExpireMonth = "12";
            cardInformation.ExpireYear = "2030";

            CreateCardRequest request = new CreateCardRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Email = "email@email.com";
            request.ExternalId = "external id";
            request.Card = cardInformation;

            Card card = Card.Create(request, options);

            PrintResponse<Card>(card);

            Assert.IsNotNull(card.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.GetName(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
        }

        [TestMethod]
        public void Should_Create_Card()
        {
            CardInformation cardInformation = new CardInformation();
            cardInformation.CardAlias = "myAlias";
            cardInformation.CardHolderName = "John Doe";
            cardInformation.CardNumber = "5528790000000008";
            cardInformation.ExpireMonth = "12";
            cardInformation.ExpireYear = "2030";

            CreateCardRequest request = new CreateCardRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CardUserKey = "myCardUserKey";
            request.Card = cardInformation;

            Card card = Card.Create(request, options);

            PrintResponse<Card>(card);

            Assert.IsNotNull(card.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.GetName(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
        }

        [TestMethod]
        public void Should_Delete_Card()
        {
            DeleteCardRequest request = new DeleteCardRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CardToken = "myCardToken";
            request.CardUserKey = "myCardUserKey";

            Card card = Card.Delete(request, options);

            PrintResponse<Card>(card);

            Assert.IsNotNull(card.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.GetName(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
        }

        [TestMethod]
        public void Should_Retrieve_Cards()
        {
            RetrieveCardListRequest request = new RetrieveCardListRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CardUserKey = "myCardUserKey";

            CardList cardList = CardList.Retrieve(request, options);

            PrintResponse<CardList>(cardList);

            Assert.IsNotNull(cardList.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), cardList.Status);
            Assert.AreEqual(Locale.TR.GetName(), cardList.Locale);
            Assert.AreEqual("123456789", cardList.ConversationId);
        }
    }
}
