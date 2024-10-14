using System;
using System.Linq;
using System.Threading.Tasks;
using Iyzipay.Model;
using Iyzipay.Model.V2;
using Iyzipay.Model.V2.Subscription;
using Iyzipay.Request;
using Iyzipay.Request.V2.Subscription;
using Iyzipay.Tests.Functional.Builder;
using Iyzipay.Tests.Functional.Builder.Request;
using Iyzipay.Tests.Functional.Util;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
	public class SubscriptionTest : BaseTest
	{

		[Test]
		public void Should_Initialize_CheckoutForm()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			InitializeCheckoutFormRequest request = new InitializeCheckoutFormRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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
					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555",
				},
				CallbackUrl = "https://www.google.com",
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.PENDING.ToString()
			};

			CheckoutFormResource response = Subscription.InitializeCheckoutForm(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.IsNotNull(response.CheckoutFormContent);
			Assert.IsNotNull(response.Token);
			Assert.IsNotNull(response.TokenExpireTime);
			Assert.Null(response.ErrorMessage);
		}
		[Test]
		public void Should_Initialize_CheckoutForm_Result()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			InitializeCheckoutFormRequest request = new InitializeCheckoutFormRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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
					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555",
				},
				CallbackUrl = "https://www.google.com",
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.PENDING.ToString()
			};

			CheckoutFormResource response = Subscription.InitializeCheckoutForm(request, _options);


			GetCheckoutFormResultRequest getCheckoutFormResultRequest = new GetCheckoutFormResultRequest()
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				Token = response.Token
			};

			ResponseData<CheckoutFormResult> resultResponse = Subscription.GetCheckoutFormResult(getCheckoutFormResultRequest, _options);

			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(resultResponse.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_Initialize_Subscription()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest request = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123",
					RegisterConsumerCard = true
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode
			};

			ResponseData<SubscriptionCreatedResource> response = Subscription.Initialize(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
			Assert.NotNull(response.Data.ReferenceCode);
			Assert.NotNull(response.Data.ParentReferenceCode);
			Assert.AreEqual(planResource.ReferenceCode, response.Data.PricingPlanReferenceCode);
			Assert.AreEqual(SubscriptionStatus.ACTIVE.ToString(), response.Data.SubscriptionStatus);
			Assert.AreEqual(3, response.Data.TrialDays);
			Assert.NotNull(response.Data.TrialStartDate);
			Assert.NotNull(response.Data.TrialEndDate);
			Assert.NotNull(response.Data.StartDate);

		}

		[Test]
		public void Should_Initialize_Subscription_With_Customer()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

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

			ResponseData<CustomerResource> customerResponse = Customer.Create(createCustomerRequest, _options);
            PrintResponse(customerResponse);
            
			Assert.AreEqual(Status.SUCCESS.ToString(), customerResponse.Status);
			Assert.IsNotNull(customerResponse.SystemTime);
			Assert.Null(customerResponse.ErrorMessage);
		
            SubscriptionInitializeWithCustomerRequest request = new SubscriptionInitializeWithCustomerRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				CustomerReferenceCode = "259c0eb3-64da-45b4-9208-c0f0083baeef",
				SubscriptionInitialStatus = "ACTIVE"
			};

			ResponseData<SubscriptionCreatedResource> response = Subscription.InitializeWithCustomer(request, _options);
			PrintResponse(response);
			

		}

		[Test]
		public async Task Should_Activate_SubscriptionAsync()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest subscriptionInitializeRequest = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123",
					RegisterConsumerCard = true
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.PENDING.ToString()
			};

			ResponseData<SubscriptionCreatedResource> initializeResponse = Subscription.Initialize(subscriptionInitializeRequest, _options);

			ActivateSubscriptionRequest request = new ActivateSubscriptionRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				SubscriptionReferenceCode = initializeResponse.Data.ReferenceCode
			};

			IyzipayResourceV2 response = Subscription.Activate(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Ignore("Test needs failed payment (OrderStatus=Failed,SubscriptionStatus=Unpaid), but we can not supply this condition in test now.")]
		public void Should_Retry_Subscription()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest subscriptionInitializeRequest = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123"
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.ACTIVE.ToString()
			};

			ResponseData<SubscriptionCreatedResource> initializeResponse = Subscription.Initialize(subscriptionInitializeRequest, _options);

			RetrieveSubscriptionRequest retrieveSubscriptionRequest = new RetrieveSubscriptionRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				SubscriptionReferenceCode = initializeResponse.Data.ReferenceCode
			};
			ResponseData<SubscriptionResource> subscriptionResponse = Subscription.Retrieve(retrieveSubscriptionRequest, _options);

			RetrySubscriptionRequest request = new RetrySubscriptionRequest()
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				SubscriptionOrderReferenceCode = subscriptionResponse.Data.SubscriptionOrders.FirstOrDefault()?.ReferenceCode
			};

			IyzipayResourceV2 response = Subscription.Retry(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_Upgrade_Subscription()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest subscriptionInitializeRequest = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123",
					RegisterConsumerCard = true
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.ACTIVE.ToString()
			};

			ResponseData<SubscriptionCreatedResource> initializeResponse = Subscription.Initialize(subscriptionInitializeRequest, _options);

			CreatePlanRequest newPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"new-plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 2,
				Price = "3.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 2,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource newPlanResource = Plan.Create(newPlanRequest, _options).Data;

			UpgradeSubscriptionRequest request = new UpgradeSubscriptionRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				SubscriptionReferenceCode = initializeResponse.Data.ReferenceCode,
				NewPricingPlanReferenceCode = newPlanResource.ReferenceCode,
				UseTrial = true,
				ResetRecurrenceCount = true,
				UpgradePeriod = SubscriptionUpgradePeriod.NOW.ToString()
			};

			IyzipayResourceV2 response = Subscription.Upgrade(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_Cancel_Subscription()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest subscriptionInitializeRequest = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123",
					RegisterConsumerCard = true
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.ACTIVE.ToString()
			};

			ResponseData<SubscriptionCreatedResource> initializeResponse = Subscription.Initialize(subscriptionInitializeRequest, _options);

			CancelSubscriptionRequest request = new CancelSubscriptionRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				SubscriptionReferenceCode = initializeResponse.Data.ReferenceCode
			};

			IyzipayResourceV2 response = Subscription.Cancel(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
		}

		[Test]
		public void Should_Retrieve_Subscription()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest subscriptionInitializeRequest = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123",
					RegisterConsumerCard = true
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.ACTIVE.ToString()
			};

			ResponseData<SubscriptionCreatedResource> initializeResponse = Subscription.Initialize(subscriptionInitializeRequest, _options);

			RetrieveSubscriptionRequest request = new RetrieveSubscriptionRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				SubscriptionReferenceCode = initializeResponse.Data.ReferenceCode
			};

			ResponseData<SubscriptionResource> response = Subscription.Retrieve(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
			Assert.NotNull(response.Data.ReferenceCode);
			Assert.NotNull(response.Data.ParentReferenceCode);
			Assert.AreEqual(planResource.ReferenceCode, response.Data.PricingPlanReferenceCode);
			Assert.AreEqual(SubscriptionStatus.ACTIVE.ToString(), response.Data.SubscriptionStatus);
			Assert.AreEqual($"iyzico-{randomString}@iyzico.com", response.Data.CustomerEmail);
			Assert.AreEqual(3, response.Data.TrialDays);
			Assert.NotNull(response.Data.TrialStartDate);
			Assert.NotNull(response.Data.TrialEndDate);
			Assert.NotNull(response.Data.StartDate);
		}

		[Test]
		public void Should_Search_Subscription()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest subscriptionInitializeRequest = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123",
					RegisterConsumerCard = true
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.ACTIVE.ToString()
			};

			ResponseData<SubscriptionCreatedResource> initializeResponse = Subscription.Initialize(subscriptionInitializeRequest, _options);

			SearchSubscriptionRequest request = new SearchSubscriptionRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				SubscriptionReferenceCode = initializeResponse.Data.ReferenceCode,
				Page = 1,
				Count = 1,
				SubscriptionStatus = SubscriptionStatus.ACTIVE.ToString(),
				PricingPlanReferenceCode = planResource.ReferenceCode
			};

			ResponsePagingData<SubscriptionResource> response = Subscription.Search(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.AreEqual(1, response.Data.Items.Count);
			Assert.AreEqual(1, response.Data.CurrentPage);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
			Assert.NotNull(response.Data.Items.First().ReferenceCode);
			Assert.NotNull(response.Data.Items.First().ParentReferenceCode);
			Assert.AreEqual(planResource.ReferenceCode, response.Data.Items.First().PricingPlanReferenceCode);
			Assert.AreEqual(SubscriptionStatus.ACTIVE.ToString(), response.Data.Items.First().SubscriptionStatus);
			Assert.AreEqual($"iyzico-{randomString}@iyzico.com", response.Data.Items.First().CustomerEmail);
			Assert.AreEqual(3, response.Data.Items.First().TrialDays);
			Assert.NotNull(response.Data.Items.First().TrialStartDate);
			Assert.NotNull(response.Data.Items.First().TrialEndDate);
			Assert.NotNull(response.Data.Items.First().StartDate);
		}

		[Test]
		public void Should_Update_Subscription_Card()
		{
			string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			CreateProductRequest createProductRequest = new CreateProductRequest
			{
				Description = "product-description",
				Locale = Locale.TR.ToString(),
				Name = $"product-name-{randomString}",
				ConversationId = "123456789"
			};

			ResponseData<ProductResource> createProductResponse = Product.Create(createProductRequest, _options);

			CreatePlanRequest createPlanRequest = new CreatePlanRequest()
			{
				Locale = Locale.TR.ToString(),
				Name = $"plan-name-{randomString}",
				ConversationId = "123456789",
				TrialPeriodDays = 3,
				Price = "5.23",
				CurrencyCode = Currency.TRY.ToString(),
				PaymentInterval = PaymentInterval.WEEKLY.ToString(),
				RecurrenceCount = 12,
				PaymentIntervalCount = 1,
				PlanPaymentType = PlanPaymentType.RECURRING.ToString(),
				ProductReferenceCode = createProductResponse.Data.ReferenceCode
			};

			PlanResource planResource = Plan.Create(createPlanRequest, _options).Data;

			SubscriptionInitializeRequest subscriptionInitializeRequest = new SubscriptionInitializeRequest
			{
				Locale = Locale.TR.ToString(),
				Customer = new CheckoutFormCustomer
				{
					Email = $"iyzico-{randomString}@iyzico.com",
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

					GsmNumber = "+905350000000",
					IdentityNumber = "55555555555"
				},
				PaymentCard = new CardInfo
				{
					CardNumber = "5528790000000008",
					CardHolderName = "iyzico",
					ExpireMonth = "12",
					ExpireYear = "2029",
					Cvc = "123",
					RegisterConsumerCard = true
				},
				ConversationId = "123456789",
				PricingPlanReferenceCode = planResource.ReferenceCode,
				SubscriptionInitialStatus = SubscriptionStatus.ACTIVE.ToString()
			};

			ResponseData<SubscriptionCreatedResource> initializeResponse = Subscription.Initialize(subscriptionInitializeRequest, _options);

			UpdateCardRequest request = new UpdateCardRequest
			{
				Locale = Locale.TR.ToString(),
				ConversationId = "123456789",
				CustomerReferenceCode = initializeResponse.Data.CustomerReferenceCode,
				CallbackUrl = "https://www.google.com"
			};

			UpdateCardFormResource response = Subscription.UpdateCard(request, _options);
			PrintResponse(response);

			Assert.AreEqual(Status.SUCCESS.ToString(), response.Status);
			Assert.IsNotNull(response.SystemTime);
			Assert.Null(response.ErrorMessage);
			Assert.NotNull(response.CheckoutFormContent);
			Assert.NotNull(response.Token);
			Assert.NotNull(response.TokenExpireTime);
		}
	}
}