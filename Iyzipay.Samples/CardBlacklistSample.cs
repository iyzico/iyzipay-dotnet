using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class CardBlacklistSample : Sample
    {
        [Test]
        public void Should_Create_Card_Blacklist()
        {
            CreateCardBlacklistRequest request = new CreateCardBlacklistRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardToken = "";
            request.CardUserKey = "";


            CardBlacklist cardBlacklist = CardBlacklist.Create(request, options);

            
            PrintResponse<CardBlacklist>(cardBlacklist);
            
            Assert.AreEqual(Status.SUCCESS.ToString(), cardBlacklist.Status);
            Assert.AreEqual(Locale.TR.ToString(), cardBlacklist.Locale);
            Assert.AreEqual("123456789", cardBlacklist.ConversationId);
            Assert.IsNotNull(cardBlacklist.SystemTime);
            Assert.IsNull(cardBlacklist.ErrorCode);
            Assert.IsNull(cardBlacklist.ErrorMessage);
            Assert.IsNull(cardBlacklist.ErrorGroup);
            Assert.IsNotNull(cardBlacklist.CardUserKey);
            Assert.IsNotNull(cardBlacklist.CardToken);
            
        }

        [Test]
        public void Should_Update_Card_Blacklist()
        {
            UpdateCardBlacklistRequest request = new UpdateCardBlacklistRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardToken = "";
            request.CardUserKey = "";


            CardBlacklist cardBlacklist = CardBlacklist.Update(request, options);

            
            PrintResponse<CardBlacklist>(cardBlacklist);

            Assert.AreEqual(Status.SUCCESS.ToString(), cardBlacklist.Status);
            Assert.AreEqual(Locale.TR.ToString(), cardBlacklist.Locale);
            Assert.AreEqual("123456789", cardBlacklist.ConversationId);
            Assert.IsNotNull(cardBlacklist.SystemTime);
            Assert.IsNull(cardBlacklist.ErrorCode);
            Assert.IsNull(cardBlacklist.ErrorMessage);
            Assert.IsNull(cardBlacklist.ErrorGroup);
            Assert.IsNotNull(cardBlacklist.CardUserKey);
            Assert.IsNotNull(cardBlacklist.CardToken);
        }

        [Test]
        public void Should_Retrieve_Blacklist_Cards()
        {
            RetrieveCardBlacklistRequest request = new RetrieveCardBlacklistRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardNumber = "";

            CardBlacklist cardBlacklist = CardBlacklist.Retrieve(request, options);

            PrintResponse<CardBlacklist>(cardBlacklist);

            Assert.AreEqual(Status.SUCCESS.ToString(), cardBlacklist.Status);
            Assert.AreEqual(Locale.TR.ToString(), cardBlacklist.Locale);
            Assert.IsNotNull(cardBlacklist.SystemTime);
            Assert.IsNull(cardBlacklist.ErrorCode);
            Assert.IsNull(cardBlacklist.ErrorMessage);
            Assert.IsNull(cardBlacklist.ErrorGroup);
            Assert.IsNotNull(cardBlacklist.CardNumber);
            Assert.IsNotNull(cardBlacklist.Blacklisted);
        }
    }
}
