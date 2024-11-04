using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class CardManagementPageSample : Sample
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            options.BaseUrl = "https://sandbox-cm.iyzipay.com";
        }
        
        [Test]
        public async Task Should_Initialize_Card_Management_PageAsync()
        {
            CreateCardManagementPageInitializeRequest request = new CreateCardManagementPageInitializeRequest
            {
                CallbackUrl = "https://merchant-callback.com",
                Email = "merchant@email.com",
                ExternalId = "123456789",
                ConversationId = "123456789",
                AddNewCardEnabled = true,
                ValidateNewCard = true,
                DebitCardAllowed = true,
                CardUserKey = "card user key",
                Locale = Locale.TR.ToString()
            };

            CardManagementPageInitialize cardManagementPageInitialize = CardManagementPageInitialize.Create(request, options);
            PrintResponse(cardManagementPageInitialize);

            Assert.AreEqual(Locale.TR.ToString(), cardManagementPageInitialize.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), cardManagementPageInitialize.Status);
            Assert.NotNull(cardManagementPageInitialize.SystemTime);
            Assert.AreEqual("123456789", cardManagementPageInitialize.ConversationId);
            Assert.NotNull(cardManagementPageInitialize.Token);
            Assert.NotNull(cardManagementPageInitialize.CardPageUrl);
            Assert.Null(cardManagementPageInitialize.ErrorMessage);
        }
    }
}