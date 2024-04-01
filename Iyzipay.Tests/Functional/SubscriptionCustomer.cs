using System;
using Iyzipay.Model;
using Iyzipay.Model.V2;
using Iyzipay.Model.V2.Subscription;
using Iyzipay.Request.V2.Subscription;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
	public class SubscriptionCustomer : BaseTest
	{
		[Test]
		public void Should_Create_Customer()
		{
			string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
			CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
			{
				Email = $"iyzico-{randomString}@iyzico.com",
				Locale = Locale.TR.ToString(),
				Name = "customer-name",
				Surname = "customer-surname",
				BillingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "billing-address-description",
					ContactName = "billing-contact-name",
					ZipCode = "010101"
				},
				ShippingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "shipping-address-description",
					ContactName = "shipping-contact-name",
					ZipCode = "010102"
				},
				ConversationId = "123456789",
				GsmNumber = "+905350000000",
				IdentityNumber = "55555555555"
			};

			ResponseData<CustomerResource> response = Customer.Create(createCustomerRequest, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.AreEqual($"iyzico-{randomString}@iyzico.com", response.Data.Email);
			Assert.AreEqual("customer-name", response.Data.Name);
			Assert.AreEqual("customer-surname", response.Data.Surname);
			Assert.AreEqual("+905350000000", response.Data.GsmNumber);
			Assert.AreEqual("55555555555", response.Data.IdentityNumber);
			Assert.AreEqual("İstanbul", response.Data.BillingAddress.City);
			Assert.AreEqual("Türkiye", response.Data.BillingAddress.Country);
			Assert.AreEqual("billing-address-description", response.Data.BillingAddress.Description);
			Assert.AreEqual("billing-contact-name", response.Data.BillingAddress.ContactName);
			Assert.AreEqual("010101", response.Data.BillingAddress.ZipCode);
			Assert.AreEqual("İstanbul", response.Data.ShippingAddress.City);
			Assert.AreEqual("Türkiye", response.Data.ShippingAddress.Country);
			Assert.AreEqual("shipping-address-description", response.Data.ShippingAddress.Description);
			Assert.AreEqual("shipping-contact-name", response.Data.ShippingAddress.ContactName);
			Assert.AreEqual("010102", response.Data.ShippingAddress.ZipCode);
			Assert.IsNotNull(response.Data.ReferenceCode);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_Update_Customer()
		{
			string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
			CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
			{
				Email = $"iyzico-{randomString}@iyzico.com",
				Locale = Locale.TR.ToString(),
				Name = "customer-name",
				Surname = "customer-surname",
				BillingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "billing-address-description",
					ContactName = "billing-contact-name",
					ZipCode = "010101"
				},
				ShippingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "shipping-address-description",
					ContactName = "shipping-contact-name",
					ZipCode = "010102"
				},
				ConversationId = "123456789",
				GsmNumber = "+905350000000",
				IdentityNumber = "55555555555"
			};

			ResponseData<CustomerResource> createCustomerResponse = Customer.Create(createCustomerRequest, _options);

			UpdateCustomerRequest updateCustomerRequest = new UpdateCustomerRequest
			{
				Locale = Locale.TR.ToString(),
				Name = "upd-customer-name",
				Surname = "upd-customer-surname",
				Enail = "upd-customer-email",
				GsmNumber = "upd-customer-gsm-number",
				BillingAddress = new Address
				{
					City = "upd-İstanbul",
					Country = "upd-Türkiye",
					Description = "upd-billing-address-description",
					ContactName = "upd-billing-contact-name",
					ZipCode = "010101"
				},
				ShippingAddress = new Address
				{
					City = "upd-İstanbul",
					Country = "upd-Türkiye",
					Description = "upd-shipping-address-description",
					ContactName = "upd-shipping-contact-name",
					ZipCode = "010102"
				},
				ConversationId = "123456789",
				IdentityNumber = "55555555551",
				CustomerReferenceCode = createCustomerResponse.Data.ReferenceCode
			};

			ResponseData<CustomerResource> response = Customer.Update(updateCustomerRequest, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.AreEqual($"iyzico-{randomString}@iyzico.com", response.Data.Email);
			Assert.AreEqual("upd-customer-name", response.Data.Name);
			Assert.AreEqual("upd-customer-surname", response.Data.Surname);
			Assert.AreEqual("+905350000000", response.Data.GsmNumber);
			Assert.AreEqual("55555555551", response.Data.IdentityNumber);
			Assert.AreEqual("upd-İstanbul", response.Data.BillingAddress.City);
			Assert.AreEqual("upd-Türkiye", response.Data.BillingAddress.Country);
			Assert.AreEqual("upd-billing-address-description", response.Data.BillingAddress.Description);
			Assert.AreEqual("upd-billing-contact-name", response.Data.BillingAddress.ContactName);
			Assert.AreEqual("010101", response.Data.BillingAddress.ZipCode);
			Assert.AreEqual("upd-İstanbul", response.Data.ShippingAddress.City);
			Assert.AreEqual("upd-Türkiye", response.Data.ShippingAddress.Country);
			Assert.AreEqual("upd-shipping-address-description", response.Data.ShippingAddress.Description);
			Assert.AreEqual("upd-shipping-contact-name", response.Data.ShippingAddress.ContactName);
			Assert.AreEqual("010102", response.Data.ShippingAddress.ZipCode);
			Assert.IsNotNull(response.Data.ReferenceCode);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_Delete_Customer()
		{
			string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
			CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
			{
				Email = $"iyzico-{randomString}@iyzico.com",
				Locale = Locale.TR.ToString(),
				Name = "customer-name",
				Surname = "customer-surname",
				BillingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "billing-address-description",
					ContactName = "billing-contact-name",
					ZipCode = "010101"
				},
				ShippingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "shipping-address-description",
					ContactName = "shipping-contact-name",
					ZipCode = "010102"
				},
				ConversationId = "123456789",
				GsmNumber = "+905350000000",
				IdentityNumber = "55555555555"
			};

			ResponseData<CustomerResource> createCustomerResponse = Customer.Create(createCustomerRequest, _options);
			DeleteCustomerRequest deleteCustomerRequest = new DeleteCustomerRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				CustomerReferenceCode = createCustomerResponse.Data.ReferenceCode
			};

			IyzipayResourceV2 response = Customer.Delete(deleteCustomerRequest, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_Retrieve_Customer()
		{
			string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
			CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
			{
				Email = $"iyzico-{randomString}@iyzico.com",
				Locale = Locale.TR.ToString(),
				Name = "customer-name",
				Surname = "customer-surname",
				BillingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "billing-address-description",
					ContactName = "billing-contact-name",
					ZipCode = "010101"
				},
				ShippingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "shipping-address-description",
					ContactName = "shipping-contact-name",
					ZipCode = "010102"
				},
				ConversationId = "123456789",
				GsmNumber = "+905350000000",
				IdentityNumber = "55555555555"
			};

			ResponseData<CustomerResource> createCustomerResponse = Customer.Create(createCustomerRequest, _options);

			RetrieveCustomerRequest retrieveCustomerRequest = new RetrieveCustomerRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				CustomerReferenceCode = createCustomerResponse.Data.ReferenceCode
			};

			ResponseData<CustomerResource> response = Customer.Retrieve(retrieveCustomerRequest, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.AreEqual($"iyzico-{randomString}@iyzico.com", response.Data.Email);
			Assert.AreEqual("customer-name", response.Data.Name);
			Assert.AreEqual("customer-surname", response.Data.Surname);
			Assert.AreEqual("+905350000000", response.Data.GsmNumber);
			Assert.AreEqual("55555555555", response.Data.IdentityNumber);
			Assert.AreEqual("İstanbul", response.Data.BillingAddress.City);
			Assert.AreEqual("Türkiye", response.Data.BillingAddress.Country);
			Assert.AreEqual("billing-address-description", response.Data.BillingAddress.Description);
			Assert.AreEqual("billing-contact-name", response.Data.BillingAddress.ContactName);
			Assert.AreEqual("010101", response.Data.BillingAddress.ZipCode);
			Assert.AreEqual("İstanbul", response.Data.ShippingAddress.City);
			Assert.AreEqual("Türkiye", response.Data.ShippingAddress.Country);
			Assert.AreEqual("shipping-address-description", response.Data.ShippingAddress.Description);
			Assert.AreEqual("shipping-contact-name", response.Data.ShippingAddress.ContactName);
			Assert.AreEqual("010102", response.Data.ShippingAddress.ZipCode);
			Assert.IsNotNull(response.Data.ReferenceCode);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_RetrieveAll_Customer()
		{
			string randomString = $"{DateTime.Now:yyyyMMddHHmmssfff}";
			CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
			{
				Email = $"iyzico-{randomString}@iyzico.com",
				Locale = Locale.TR.ToString(),
				Name = "customer-name",
				Surname = "customer-surname",
				BillingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "billing-address-description",
					ContactName = "billing-contact-name",
					ZipCode = "010101"
				},
				ShippingAddress = new Address
				{
					City = "İstanbul",
					Country = "Türkiye",
					Description = "shipping-address-description",
					ContactName = "shipping-contact-name",
					ZipCode = "010102"
				},
				ConversationId = "123456789",
				GsmNumber = "+905350000000",
				IdentityNumber = "55555555555"
			};

			Customer.Create(createCustomerRequest, _options);

			PagingRequest pagingRequest = new PagingRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				Page = 1,
				Count = 1
			};

			ResponsePagingData<CustomerResource> response = Customer.RetrieveAll(pagingRequest, _options);
			PrintResponse(response);

			Assert.AreEqual(response.Status, Status.SUCCESS.ToString());
			Assert.AreEqual(1, response.Data.Items.Count);
			Assert.AreEqual(1, response.Data.CurrentPage);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

	}
}