using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using Iyzipay.Tests.Functional.Util;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class SubMerchantTest : BaseTest
    {
        [Test]
        public async Task Should_Create_personal_Sub_MerchantAsync()
        {
            string subMerchantExternalId = RandomGenerator.RandomId;
            CreateSubMerchantRequest request = CreateSubMerchantRequestBuilder.Create()
                .SubMerchantType(SubMerchantType.PERSONAL.ToString())
                .ContactName("John")
                .ContactSurname("Doe")
                .IdentityNumber("123456789")
                .SubMerchantExternalId(subMerchantExternalId)
                .Build();

            SubMerchant subMerchant = await SubMerchant.Create(request, _options);

            PrintResponse(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.NotNull(subMerchant.SystemTime);
            Assert.Null(subMerchant.ErrorMessage);
        }

        [Test]
        public async Task Should_Create_Private_Sub_MerchantAsync()
        {
            string subMerchantExternalId = RandomGenerator.RandomId;
            CreateSubMerchantRequest request = CreateSubMerchantRequestBuilder.Create()
                .SubMerchantType(SubMerchantType.PRIVATE_COMPANY.ToString())
                .LegalCompanyTitle("John Doe inc")
                .TaxOffice("Tax office")
                .IdentityNumber("31300864726")
                .SubMerchantExternalId(subMerchantExternalId)
                .Build();

            SubMerchant subMerchant = await SubMerchant.Create(request, _options);

            PrintResponse(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.NotNull(subMerchant.SystemTime);
            Assert.Null(subMerchant.ErrorMessage);
        }

        [Test]
        public async Task Should_Create_Limited_Company_Sub_MerchantAsync()
        {
            string subMerchantExternalId = RandomGenerator.RandomId;
            CreateSubMerchantRequest request = CreateSubMerchantRequestBuilder.Create()
                .SubMerchantExternalId(subMerchantExternalId)
                .SubMerchantType(SubMerchantType.LIMITED_OR_JOINT_STOCK_COMPANY.ToString())
                .TaxOffice("Tax office")
                .TaxNumber("9261877")
                .LegalCompanyTitle("XYZ inc")
                .Build();

            SubMerchant subMerchant = await SubMerchant.Create(request, _options);

            PrintResponse(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.NotNull(subMerchant.SystemTime);
            Assert.Null(subMerchant.ErrorMessage);
        }

        [Test]
        public async Task Should_Update_Personal_Sub_MerchantAsync()
        {
            CreateSubMerchantRequest createPersonalSubMerchantRequest = CreateSubMerchantRequestBuilder.Create()
                .PersonalSubMerchantRequest()
                .Build();

            string subMerchantKey = (await SubMerchant.Create(createPersonalSubMerchantRequest, _options)).SubMerchantKey;

            UpdateSubMerchantRequest updateSubMerchantRequest = UpdateSubMerchantRequestBuilder.Create()
                .SubMerchantKey(subMerchantKey)
                .ContactName("Jane")
                .ContactSurname("Doe")
                .IdentityNumber("31300864726")
                .Name("Jane's market")
                .Build();

            SubMerchant subMerchant = await SubMerchant.Update(updateSubMerchantRequest, _options);

            PrintResponse(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.NotNull(subMerchant.SystemTime);
            Assert.Null(subMerchant.ErrorMessage);
        }

        [Test]
        public async Task Should_Update_Private_Sub_MerchantAsync()
        {
            CreateSubMerchantRequest createPrivateSubMerchantRequest = CreateSubMerchantRequestBuilder.Create()
                .PrivateSubMerchantRequest()
                .Build();

            string subMerchantKey = (await SubMerchant.Create(createPrivateSubMerchantRequest, _options)).SubMerchantKey;

            UpdateSubMerchantRequest updateSubMerchantRequest = UpdateSubMerchantRequestBuilder.Create()
                .SubMerchantKey(subMerchantKey)
                .IdentityNumber("31300864726")
                .TaxOffice("Tax office")
                .LegalCompanyTitle("Jane Doe inc")
                .Build();

            SubMerchant subMerchant = await SubMerchant.Update(updateSubMerchantRequest, _options);

            PrintResponse(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.NotNull(subMerchant.SystemTime);
            Assert.Null(subMerchant.ErrorMessage);
        }

        [Test]
        public async Task Should_Update_Limited_Company_Sub_MerchantAsync()
        {
            CreateSubMerchantRequest createLimitedCompanySubMerchantRequest = CreateSubMerchantRequestBuilder.Create()
                .LimitedCompanySubMerchantRequest()
                .Build();

            string subMerchantKey = (await SubMerchant.Create(createLimitedCompanySubMerchantRequest, _options)).SubMerchantKey;

            UpdateSubMerchantRequest updateSubMerchantRequest = UpdateSubMerchantRequestBuilder.Create()
                .SubMerchantKey(subMerchantKey)
                .Name("Jane's market")
                .IdentityNumber("31300864726")
                .TaxOffice("Tax office")
                .LegalCompanyTitle("ABC inc")
                .Build();

            SubMerchant subMerchant = await SubMerchant.Update(updateSubMerchantRequest, _options);

            PrintResponse(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.NotNull(subMerchant.SystemTime);
            Assert.Null(subMerchant.ErrorMessage);
        }

        [Test]
        public async Task Should_Retrieve_Sub_MerchantAsync()
        {
            string subMerchantExternalId = RandomGenerator.RandomId;
            CreateSubMerchantRequest createLimitedCompanySubMerchantRequest = CreateSubMerchantRequestBuilder.Create()
                .LimitedCompanySubMerchantRequest()
                .SubMerchantExternalId(subMerchantExternalId)
                .Build();

            await SubMerchant.Create(createLimitedCompanySubMerchantRequest, _options);

            RetrieveSubMerchantRequest request = RetrieveSubMerchantRequestBuilder.Create()
                .SubMerchantExternalId(subMerchantExternalId)
                .Build();

            SubMerchant subMerchant = await SubMerchant.Retrieve(request, _options);

            PrintResponse(subMerchant);

            Assert.AreEqual(Status.SUCCESS.ToString(), subMerchant.Status);
            Assert.AreEqual(Locale.TR.ToString(), subMerchant.Locale);
            Assert.AreEqual("123456789", subMerchant.ConversationId);
            Assert.AreEqual("9261877", subMerchant.TaxNumber);
            Assert.AreEqual("TR180006200119000006672315", subMerchant.Iban);
            Assert.AreEqual("Tax office", subMerchant.TaxOffice);
            Assert.AreEqual(subMerchantExternalId, subMerchant.SubMerchantExternalId);
            Assert.NotNull(subMerchant.SystemTime);
            Assert.Null(subMerchant.ErrorMessage);
        }
    }
}
