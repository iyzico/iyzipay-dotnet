﻿using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class CardStorageSample : Sample
    {
        [Test]
        public async Task Should_Create_User_And_Add_CardAsync()
        {
            CreateCardRequest request = new CreateCardRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Email = "email@email.com";
            request.ExternalId = "external id";

            CardInformation cardInformation = new CardInformation();
            cardInformation.CardAlias = "card alias";
            cardInformation.CardHolderName = "John Doe";
            cardInformation.CardNumber = "5528790000000008";
            cardInformation.ExpireMonth = "12";
            cardInformation.ExpireYear = "2030";
            request.Card = cardInformation;

            Card card = await Card.Create(request, options);

            PrintResponse<Card>(card);

            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.ToString(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
            Assert.IsNotNull(card.SystemTime);
            Assert.IsNull(card.ErrorMessage);
            Assert.AreEqual("55287900", card.BinNumber);
            Assert.AreEqual("card alias", card.CardAlias);
            Assert.AreEqual("CREDIT_CARD", card.CardType);
            Assert.AreEqual("MASTER_CARD", card.CardAssociation);
            Assert.AreEqual("Paraf", card.CardFamily);
            Assert.AreEqual("Halk Bankası", card.CardBankName);
            Assert.AreEqual(12, card.CardBankCode);
            Assert.IsNotNull(card.CardUserKey);
            Assert.IsNotNull(card.CardToken);
            Assert.AreEqual("email@email.com", card.Email);
            Assert.AreEqual("external id", card.ExternalId);
        }

        [Test]
        public async Task Should_Create_CardAsync()
        {
            CreateCardRequest request = new CreateCardRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardUserKey = "card user key";

            CardInformation cardInformation = new CardInformation();
            cardInformation.CardAlias = "card alias";
            cardInformation.CardHolderName = "John Doe";
            cardInformation.CardNumber = "5528790000000008";
            cardInformation.ExpireMonth = "12";
            cardInformation.ExpireYear = "2030";
            request.Card = cardInformation;

            Card card = await Card.Create(request, options);

            PrintResponse<Card>(card);

            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.ToString(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
            Assert.IsNotNull(card.SystemTime);
            Assert.IsNull(card.ErrorMessage);
            Assert.AreEqual("55287900", card.BinNumber);
            Assert.AreEqual("card alias", card.CardAlias);
            Assert.AreEqual("CREDIT_CARD", card.CardType);
            Assert.AreEqual("MASTER_CARD", card.CardAssociation);
            Assert.AreEqual("Paraf", card.CardFamily);
            Assert.AreEqual("Halk Bankası", card.CardBankName);
            Assert.AreEqual(12, card.CardBankCode);
            Assert.IsNotNull(card.CardUserKey);
            Assert.IsNotNull(card.CardToken);
            Assert.IsNull(card.Email);
            Assert.IsNull(card.ExternalId);
        }

        [Test]
        public async Task Should_Delete_CardAsync()
        {
            DeleteCardRequest request = new DeleteCardRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardToken = "card token";
            request.CardUserKey = "card user key";

            Card card = await Card.Delete(request, options);

            PrintResponse<Card>(card);

            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.ToString(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
            Assert.IsNotNull(card.SystemTime);
            Assert.IsNull(card.ErrorMessage);
            Assert.IsNull(card.BinNumber);
            Assert.IsNull(card.CardAlias);
            Assert.IsNull(card.CardType);
            Assert.IsNull(card.CardAssociation);
            Assert.IsNull(card.CardFamily);
            Assert.IsNull(card.CardBankName);
            Assert.IsNull(card.CardBankCode);
            Assert.IsNull(card.CardUserKey);
            Assert.IsNull(card.CardToken);
            Assert.IsNull(card.Email);
            Assert.IsNull(card.ExternalId);
        }

        [Test]
        public async Task Should_Retrieve_CardsAsync()
        {
            RetrieveCardListRequest request = new RetrieveCardListRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardUserKey = "card user key";

            CardList cardList = await CardList.Retrieve(request, options);

            PrintResponse<CardList>(cardList);

            Assert.AreEqual(Status.SUCCESS.ToString(), cardList.Status);
            Assert.AreEqual(Locale.TR.ToString(), cardList.Locale);
            Assert.AreEqual("123456789", cardList.ConversationId);
            Assert.IsNotNull(cardList.SystemTime);
            Assert.IsNull(cardList.ErrorMessage);
            Assert.IsNotNull(cardList.CardDetails);
            Assert.IsNotEmpty(cardList.CardDetails);
            Assert.IsNotNull(cardList.CardUserKey);
        }
    }
}
