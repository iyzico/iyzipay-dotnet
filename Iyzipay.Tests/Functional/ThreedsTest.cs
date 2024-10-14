using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class ThreedsTest : BaseTest
    {
        [Test]
        public async Task Should_Create_Payment_With_Physical_And_Virtual_Item_For_Standard_MerchantAsync()
        {
            CreatePaymentRequest createPaymentRequest = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .CallbackUrl("https://www.merchant.com/callback")
                .Build();

            ThreedsInitialize threedsInitialize = await ThreedsInitialize.Create(createPaymentRequest, _options);

            PrintResponse(threedsInitialize);

            Assert.AreEqual(Locale.TR.ToString(), threedsInitialize.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsInitialize.Status);
            Assert.NotNull(threedsInitialize.SystemTime);
            Assert.NotNull(threedsInitialize.HtmlContent);
            Assert.Null(threedsInitialize.ErrorMessage);
        }

        [Test]
        public async Task Should_Create_Threeds_Payment_With_Physical_And_Virtual_Item_For_Marketplace_MerchantAsync()
        {
            CreateSubMerchantRequest createSubMerchantRequest = CreateSubMerchantRequestBuilder.Create()
                .PersonalSubMerchantRequest()
                .Build();

            SubMerchant subMerchant = await SubMerchant.Create(createSubMerchantRequest, _options);

            CreatePaymentRequest createPaymentRequest = CreatePaymentRequestBuilder.Create()
                .MarketplacePayment(subMerchant.SubMerchantKey)
                .CallbackUrl("https://www.merchant.com/callback")
                .Build();

			ThreedsInitialize threedsInitialize = await ThreedsInitialize.Create(createPaymentRequest, _options);

            PrintResponse(threedsInitialize);

            Assert.AreEqual(Locale.TR.ToString(), threedsInitialize.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsInitialize.Status);
            Assert.NotNull(threedsInitialize.SystemTime);
            Assert.NotNull(threedsInitialize.HtmlContent);
            Assert.Null(threedsInitialize.ErrorMessage);
        }

        /*
            This test needs manual payment from Pecco on sandbox environment. So it does not contain any assertions.
        */
        [Test]
        public async Task Should_Auth_ThreedsAsync()
        {
            CreateThreedsPaymentRequest createThreedsPaymentRequest = new CreateThreedsPaymentRequest();
            createThreedsPaymentRequest.ConversationData = "conversion data";
            createThreedsPaymentRequest.PaymentId = "1";
            createThreedsPaymentRequest.Locale = Locale.TR.ToString();
            createThreedsPaymentRequest.ConversationId = "123456789";

            ThreedsPayment threedsPayment = await ThreedsPayment.Create(createThreedsPaymentRequest, _options);

            PrintResponse(threedsPayment);
        }
    }
}