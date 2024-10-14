using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class CardManagementPageTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _options.BaseUrl = "https://sandbox-cm.iyzipay.com";
        }


        [Test]
        public async Task Should_Initialize_Card_Management_PageAsync()
        {
            CreateCardManagementPageInitializeRequest request = CardManagementPageRequestBuilder.Create().Build();

            CardManagementPageInitialize cardManagementPageInitialize = CardManagementPageInitialize.Create(request, _options);
            PrintResponse(cardManagementPageInitialize);

            Assert.AreEqual(Locale.TR.ToString(), cardManagementPageInitialize.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), cardManagementPageInitialize.Status);
            Assert.NotNull(cardManagementPageInitialize.SystemTime);
            Assert.AreEqual("123456789", cardManagementPageInitialize.ConversationId);
            Assert.NotNull(cardManagementPageInitialize.Token);
            Assert.NotNull(cardManagementPageInitialize.CardPageUrl);
            Assert.Null(cardManagementPageInitialize.ErrorMessage);
        }

        [Test]
        public async Task Should_Not_Initialize_Card_Management_Page_When_CallbackUrl_Not_ExistAsync()
        {
            CreateCardManagementPageInitializeRequest request = CardManagementPageRequestBuilder.Create().CallbackUrl("").Build();
            
            CardManagementPageInitialize cardManagementPageInitialize = CardManagementPageInitialize.Create(request, _options);
            PrintResponse(cardManagementPageInitialize);

            Assert.AreEqual(Status.FAILURE.ToString(), cardManagementPageInitialize.Status);
            Assert.Null(cardManagementPageInitialize.ExternalId);
            Assert.Null(cardManagementPageInitialize.ConversationId);
            Assert.Null(cardManagementPageInitialize.Token);
            Assert.Null(cardManagementPageInitialize.CardPageUrl);
            Assert.AreEqual("Callback url gönderilmesi zorunludur", cardManagementPageInitialize.ErrorMessage);
        }
    }
}