using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder;
using Iyzipay.Tests.Functional.Builder.Request;
using Iyzipay.Tests.Functional.Util;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class CardStorageTest : BaseTest
    {
        [Test]
        public void Should_Create_User_And_Add_Card()
        {
            string externalUserId = RandomGenerator.RandomId;
            CardInformation cardInformation = CardInformationBuilder
                .Create()
                .Build();

            CreateCardRequest createCardRequest = CreateCardRequestBuilder.Create()
                .Card(cardInformation)
                .ExternalId(externalUserId)
                .Email("email@email.com")
                .Build();

            Card card = Card.Create(createCardRequest, Options);

            PrintResponse(card);

            Assert.AreEqual(Locale.TR.ToString(), card.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.NotNull(card.SystemTime);
            Assert.AreEqual("123456789", card.ConversationId);
            Assert.AreEqual("email@email.com", card.Email);
            Assert.AreEqual("552879", card.BinNumber);
            Assert.AreEqual("card alias", card.CardAlias);
            Assert.AreEqual("CREDIT_CARD", card.CardType);
            Assert.AreEqual("MASTER_CARD", card.CardAssociation);
            Assert.AreEqual("Paraf", card.CardFamily);
            Assert.AreEqual("Halk Bankası", card.CardBankName);
            Assert.True(card.CardBankCode.Equals(12L));
        }

        [Test]
        public void Should_Create_Card_And_Add_Card_To_Existing_User()
        {
            string externalUserId = RandomGenerator.RandomId;
            CardInformation cardInformation = CardInformationBuilder.Create()
                .Build();

            CreateCardRequest cardRequest = CreateCardRequestBuilder.Create()
                .Card(cardInformation)
                .ExternalId(externalUserId)
                .Email("email@email.com")
                .Build();

            Card firstCard = Card.Create(cardRequest, Options);
            string cardUserKey = firstCard.CardUserKey;

            CreateCardRequest request = CreateCardRequestBuilder.Create()
                .Card(cardInformation)
                .CardUserKey(cardUserKey)
                .ExternalId(externalUserId)
                .Build();

            Card card = Card.Create(request, Options);

            PrintResponse(card);

            Assert.AreEqual(Locale.TR.ToString(), card.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.NotNull(card.SystemTime);
            Assert.AreEqual("123456789", card.ConversationId);
            Assert.AreEqual("552879", card.BinNumber);
            Assert.AreEqual("card alias", card.CardAlias);
            Assert.AreEqual("CREDIT_CARD", card.CardType);
            Assert.AreEqual("MASTER_CARD", card.CardAssociation);
            Assert.AreEqual("Paraf", card.CardFamily);
            Assert.AreEqual("Halk Bankası", card.CardBankName);
            Assert.AreEqual(externalUserId, card.ExternalId);
            Assert.True(card.CardBankCode.Equals(12L));
        }

        [Test]
        public void Should_Delete_Card()
        {
            Card card = CreateCard();

            DeleteCardRequest deleteCardRequest = new DeleteCardRequest();
            deleteCardRequest.CardToken = card.CardToken;
            deleteCardRequest.CardUserKey = card.CardUserKey;

            Card deletedCard = Card.Delete(deleteCardRequest, Options);

            PrintResponse(deletedCard);

            Assert.AreEqual(Status.SUCCESS.ToString(), deletedCard.Status);
            Assert.AreEqual(Locale.TR.ToString(), deletedCard.Locale);
            Assert.NotNull(deletedCard.SystemTime);
            Assert.Null(deletedCard.ErrorCode);
            Assert.Null(deletedCard.ErrorMessage);
            Assert.Null(deletedCard.ErrorGroup);
            Assert.Null(deletedCard.BinNumber);
            Assert.Null(deletedCard.CardAlias);
            Assert.Null(deletedCard.CardType);
            Assert.Null(deletedCard.CardAssociation);
            Assert.Null(deletedCard.CardFamily);
            Assert.Null(deletedCard.CardBankName);
            Assert.Null(deletedCard.CardBankCode);
            Assert.Null(deletedCard.CardUserKey);
            Assert.Null(deletedCard.CardToken);
            Assert.Null(deletedCard.Email);
            Assert.Null(deletedCard.ExternalId);
        }

        [Test]
        public void Chould_Retrieve_Card()
        {
            Card card = CreateCard();

            RetrieveCardListRequest request = new RetrieveCardListRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardUserKey = card.CardUserKey;

            CardList cardList = CardList.Retrieve(request, Options);

            PrintResponse(cardList);

            Assert.AreEqual(Status.SUCCESS.ToString(), cardList.Status);
            Assert.AreEqual(Locale.TR.ToString(), cardList.Locale);
            Assert.AreEqual("123456789", cardList.ConversationId);
            Assert.NotNull(cardList.SystemTime);
            Assert.Null(cardList.ErrorCode);
            Assert.Null(cardList.ErrorMessage);
            Assert.Null(cardList.ErrorGroup);
            Assert.NotNull(cardList.CardDetails);
            Assert.False(cardList.CardDetails.Count == 0);
            Assert.NotNull(cardList.CardUserKey);
        }

        private Card CreateCard()
        {
            CardInformation cardInformation = CardInformationBuilder.Create()
                .Build();

            CreateCardRequest cardRequest = CreateCardRequestBuilder.Create()
                .Card(cardInformation)
                .Email("email@email.com")
                .Build();

            return Card.Create(cardRequest, Options);
        }
    }
}
