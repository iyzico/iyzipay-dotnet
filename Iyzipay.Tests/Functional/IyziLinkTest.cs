using Iyzipay.Model;
using Iyzipay.Model.V2;
using Iyzipay.Model.V2.Iyzilink;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Util;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class IyziLinkTest : BaseTest
    {

        /*[Test]
        public void Should_Create_IyziLink()
        {
            IyziLinkSaveRequest request = new IyziLinkSaveRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Name = "ft-name";
            request.Description = "ft-description";
            request.Base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8H8BwGwAF0QIs4BDpAAAAAABJRU5ErkJggg==";
            request.Price = "1";
            request.Currency = Currency.TRY.ToString();
            request.AddressIgnorable = false;
            request.StockEnabled = true;
            request.StockCount = 1;
            request.InstallmentRequested = false;
            request.SourceType = "API";
            
            ResponseData<IyziLinkSave> response = IyziLink.Create(request, _options);
            PrintResponse(response);
            
            Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
            Assert.AreEqual(Locale.TR.ToString(), response.Locale);
            Assert.AreEqual("123456789", response.ConversationId);
            Assert.NotNull(response.SystemTime);
            Assert.NotNull(response.Data.Url);
            Assert.NotNull(response.Data.ImageUrl);
            Assert.NotNull(response.Data.Token);
        }*/

        /*[Test]
        public void Should_Update_IyziLink()
        {
            IyziLinkSaveRequest request = new IyziLinkSaveRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Name = "ft-name";
            request.Description = "ft-description";
            request.Base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8H8BwGwAF0QIs4BDpAAAAAABJRU5ErkJggg==";
            request.Price = "1";
            request.Currency = Currency.TRY.ToString();
            request.AddressIgnorable = false;
            request.SoldLimit = 1;
            request.InstallmentRequested = false;
            
            string token = IyziLink.Create(request, _options).Data.Token;
            
            IyziLinkSaveRequest updateRequest = new IyziLinkSaveRequest();
            updateRequest.Locale = Locale.TR.ToString();
            updateRequest.ConversationId = "123456789";
            updateRequest.Name = "ft-name-updated";
            updateRequest.Description = "ft-description-updated";
            updateRequest.Base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8H8BwGwAF0QIs4BDpAAAAAABJRU5ErkJggg==";
            updateRequest.Price = "10";
            updateRequest.Currency = Currency.TRY.ToString();
            updateRequest.AddressIgnorable = false;
            updateRequest.SoldLimit = 1;
            updateRequest.InstallmentRequested = false;
            
            ResponseData<IyziLinkSave> response = IyziLink.Update(token, updateRequest, _options);
            PrintResponse(response);
            
            Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
            Assert.AreEqual(Locale.TR.ToString(), response.Locale);
            Assert.AreEqual("123456789", response.ConversationId);
            Assert.NotNull(response.SystemTime);
            Assert.NotNull(response.Data.Url);
            Assert.NotNull(response.Data.ImageUrl);
            Assert.NotNull(response.Data.Token);
        }*/

        /*[Test]
        public void Should_Retrieve_IyziLinks_With_Pagination()
        {
            IyziLinkSaveRequest request = new IyziLinkSaveRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Name = "ft-name";
            request.Description = "ft-description";
            request.Base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8H8BwGwAF0QIs4BDpAAAAAABJRU5ErkJggg==";
            request.Price = "1";
            request.Currency = Currency.TRY.ToString();
            request.AddressIgnorable = false;
            request.SoldLimit = 1;
            request.InstallmentRequested = false;
            
            IyziLink.Create(request, _options);
            
            PagingRequest pagingRequest = new PagingRequest();
            pagingRequest.Page = 1;
            pagingRequest.Count = 1;
            pagingRequest.Locale = Locale.TR.ToString();
            pagingRequest.ConversationId = "123456789";


            ResponsePagingData<IyziLinkItem> response = IyziLink.RetrieveAll(pagingRequest, _options);
            PrintResponse(response);
            
            Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
            Assert.AreEqual(Locale.TR.ToString(), response.Locale);
            Assert.AreEqual("123456789", response.ConversationId);
            Assert.NotNull(response.SystemTime);
            Assert.AreEqual(1,response.Data.Items.Count);
            Assert.AreEqual(1,response.Data.CurrentPage);
        }*/

        /*[Test]
        public void Should_Retrieve_IyziLink_With_Token()
        {
            IyziLinkSaveRequest request = new IyziLinkSaveRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Name = "ft-name";
            request.Description = "ft-description";
            request.Base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8H8BwGwAF0QIs4BDpAAAAAABJRU5ErkJggg==";
            request.Price = "1";
            request.Currency = Currency.TRY.ToString();
            request.AddressIgnorable = false;
            request.SoldLimit = 1;
            request.InstallmentRequested = false;
            
            string token = IyziLink.Create(request, _options).Data.Token;
            BaseRequestV2 requestV2 = new BaseRequestV2();
            requestV2.Locale = Locale.TR.ToString();
            requestV2.ConversationId = "123456789";

            ResponseData<IyziLinkItem> response = IyziLink.Retrieve(token, requestV2, _options);
            PrintResponse(response);
            
            Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
            Assert.AreEqual(Locale.TR.ToString(), response.Locale);
            Assert.AreEqual("123456789", response.ConversationId);
            Assert.NotNull(response.SystemTime);
            Assert.AreEqual("ft-name",response.Data.Name);
            Assert.AreEqual("ft-description",response.Data.Description);
            Assert.AreEqual("1",response.Data.Price.RemoveTrailingZeros());
            Assert.AreEqual(Currency.TRY.ToString(),response.Data.Currency);
            Assert.AreEqual(token,response.Data.Token);
            Assert.AreEqual(IyziLinkStatus.ACTIVE,response.Data.IyziLinkStatus);
            Assert.AreEqual(false,response.Data.AddressIgnorable);
            Assert.NotNull(response.Data.ImageUrl);
        }*/

        /*[Test]
        public void Should_Delete_IyziLink()
        {
            IyziLinkSaveRequest request = new IyziLinkSaveRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Name = "ft-name";
            request.Description = "ft-description";
            request.Base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8H8BwGwAF0QIs4BDpAAAAAABJRU5ErkJggg==";
            request.Price = "1";
            request.Currency = Currency.TRY.ToString();
            request.AddressIgnorable = false;
            request.SoldLimit = 1;
            request.InstallmentRequested = false;
            
            string token = IyziLink.Create(request, _options).Data.Token;
            BaseRequestV2 requestV2 = new BaseRequestV2();
            requestV2.Locale = Locale.TR.ToString();
            requestV2.ConversationId = "123456789";

            IyzipayResourceV2 response = IyziLink.Delete(token, requestV2, _options);
            PrintResponse(response);
            
            Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
            Assert.AreEqual(Locale.TR.ToString(), response.Locale);
            Assert.AreEqual("123456789", response.ConversationId);
            Assert.NotNull(response.SystemTime);
        }*/
    }
}