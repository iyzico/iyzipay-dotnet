using System;
using Iyzipay.Model;
using Iyzipay.Model.V2;
using Iyzipay.Model.V2.Subscription;
using Iyzipay.Request.V2.Subscription;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class SubscriptionProductTest : BaseTest
    {
        [Test]
        public void Should_Create_Product()
        {
            string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
            CreateProductRequest request = new CreateProductRequest
            {
                Description = "product-description",
                Locale = Locale.TR.ToString(),
                Name = $"product-name-{randomString}",
                ConversationId = "123456789"
            };

            ResponseData<ProductResource> response = Product.Create(request, _options);
            PrintResponse(response);
            
            Assert.AreEqual(Status.SUCCESS.ToString(),response.Status);
            Assert.AreEqual($"product-name-{randomString}",response.Data.Name);
            Assert.AreEqual("product-description",response.Data.Description);
            Assert.IsNotNull(response.Data.ReferenceCode);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_Update_Product()
        {
            string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
            CreateProductRequest createProductRequest = new CreateProductRequest
            {
                Description = "product-description",
                Locale = Locale.TR.ToString(),
                Name = $"product-name-{randomString}",
                ConversationId = "123456789"
            };

            ProductResource productResource = Product.Create(createProductRequest, _options).Data;

            UpdateProductRequest updateProductRequest = new UpdateProductRequest
            {
                Description = "updated-description",
                Locale = Locale.TR.ToString(),
                Name = $"updated-product-name-{randomString}",
                ConversationId = "123456789",
                ProductReferenceCode = productResource.ReferenceCode
            };

            ResponseData<ProductResource> response = Product.Update(updateProductRequest, _options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.AreEqual($"updated-product-name-{randomString}",response.Data.Name);
            Assert.AreEqual("updated-description",response.Data.Description);
            Assert.AreEqual(productResource.ReferenceCode,response.Data.ReferenceCode);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_Delete_Product()
        {
            string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
            CreateProductRequest createProductRequest = new CreateProductRequest
            {
                Description = "product-description",
                Locale = Locale.TR.ToString(),
                Name = $"product-name-{randomString}",
                ConversationId = "123456789"
            };

            ProductResource productResource = Product.Create(createProductRequest, _options).Data;

            DeleteProductRequest updateProductRequest = new DeleteProductRequest
            {
                Locale = Locale.TR.ToString(),
                ConversationId = "123456789",
                ProductReferenceCode = productResource.ReferenceCode
            };

            IyzipayResourceV2 response = Product.Delete(updateProductRequest, _options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_Retrieve_Product()
        {
            string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
            CreateProductRequest createProductRequest = new CreateProductRequest
            {
                Description = "product-description",
                Locale = Locale.TR.ToString(),
                Name = $"product-name-{randomString}",
                ConversationId = "123456789"
            };

            ProductResource productResource = Product.Create(createProductRequest, _options).Data;

            RetrieveProductRequest retrieveProductRequest = new RetrieveProductRequest
            {
                Locale = Locale.TR.ToString(),
                ConversationId = "123456789",
                ProductReferenceCode = productResource.ReferenceCode
            };

            ResponseData<ProductResource> response = Product.Retrieve(retrieveProductRequest, _options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.AreEqual($"product-name-{randomString}",response.Data.Name);
            Assert.AreEqual("product-description",response.Data.Description);
            Assert.IsNotNull(response.Data.ReferenceCode);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_RetrieveAll_Product()
        {
            string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
            CreateProductRequest createProductRequest = new CreateProductRequest
            {
                Description = "product-description",
                Locale = Locale.TR.ToString(),
                Name = $"product-name-{randomString}",
                ConversationId = "123456789"
            };

            Product.Create(createProductRequest, _options);
            PagingRequest pagingRequest = new PagingRequest
            {
                Locale = Locale.TR.ToString(),
                ConversationId = "123456789",
                Page = 1,
                Count = 1
            };

            ResponsePagingData<ProductResource> response = Product.RetrieveAll(pagingRequest, _options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.AreEqual(1,response.Data.Items.Count);
            Assert.AreEqual(1, response.Data.CurrentPage);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
    }
}