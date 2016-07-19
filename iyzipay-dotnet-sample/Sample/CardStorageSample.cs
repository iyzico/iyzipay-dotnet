// <copyright file="CardStorageSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Card storage sample
    /// </summary>
    [TestClass]
    public class CardStorageSample : Sample
    {
        /// <summary>
        /// Should create user and add card.
        /// </summary>
        [TestMethod]
        public void ShouldCreateUserAndAddCard()
        {
            var cardInformation = new CardInformation();
            cardInformation.CardAlias = "card alias";
            cardInformation.CardHolderName = "John Doe";
            cardInformation.CardNumber = "5528790000000008";
            cardInformation.ExpireMonth = "12";
            cardInformation.ExpireYear = "2030";

            var request = new CreateCardRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Email = "email@email.com";
            request.ExternalId = "external id";
            request.Card = cardInformation;

            var card = Card.Create(request, Options);

            this.PrintResponse<Card>(card);

            Assert.IsNotNull(card.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.GetName(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
        }

        /// <summary>
        /// Should create card.
        /// </summary>
        [TestMethod]
        public void ShouldCreateCard()
        {
            var cardInformation = new CardInformation();
            cardInformation.CardAlias = "card alias";
            cardInformation.CardHolderName = "John Doe";
            cardInformation.CardNumber = "5528790000000008";
            cardInformation.ExpireMonth = "12";
            cardInformation.ExpireYear = "2030";

            var request = new CreateCardRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CardUserKey = "card user key";
            request.Card = cardInformation;

            var card = Card.Create(request, Options);

            this.PrintResponse<Card>(card);

            Assert.IsNotNull(card.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.GetName(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
        }

        /// <summary>
        /// Should delete card.
        /// </summary>
        [TestMethod]
        public void ShouldDeleteCard()
        {
            var request = new DeleteCardRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CardToken = "card token";
            request.CardUserKey = "card user key";

            var card = Card.Delete(request, Options);

            this.PrintResponse<Card>(card);

            Assert.IsNotNull(card.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), card.Status);
            Assert.AreEqual(Locale.TR.GetName(), card.Locale);
            Assert.AreEqual("123456789", card.ConversationId);
        }

        /// <summary>
        /// Should retrieve cards.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveCards()
        {
            var request = new RetrieveCardListRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CardUserKey = "card user key";

            var cardList = CardList.Retrieve(request, Options);

            this.PrintResponse<CardList>(cardList);

            Assert.IsNotNull(cardList.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), cardList.Status);
            Assert.AreEqual(Locale.TR.GetName(), cardList.Locale);
            Assert.AreEqual("123456789", cardList.ConversationId);
        }
    }
}
