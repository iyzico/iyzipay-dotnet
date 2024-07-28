using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class CardBlacklistSample : Sample
    {
        [Test]
        public async Task Should_Create_Card_BlacklistAsync()
        {
            CreateCardBlacklistRequest request = new CreateCardBlacklistRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardToken = "";
            request.CardUserKey = "";


            CardBlacklist cardBlacklist = await CardBlacklist.Create(request, options);

            
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
        public async Task Should_Update_Card_BlacklistAsync()
        {
            UpdateCardBlacklistRequest request = new UpdateCardBlacklistRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardToken = "";
            request.CardUserKey = "";


            CardBlacklist cardBlacklist = await CardBlacklist.Update(request, options);

            
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
        public async Task Should_Retrieve_Blacklist_CardsAsync()
        {
            RetrieveCardBlacklistRequest request = new RetrieveCardBlacklistRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.CardNumber = "";

            CardBlacklist cardBlacklist = await CardBlacklist.Retrieve(request, options);

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
