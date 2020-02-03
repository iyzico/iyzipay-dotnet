using System;
using Iyzipay.Model;
using Iyzipay.Model.V2;
using Iyzipay.Model.V2.Subscription;
using Iyzipay.Request.V2.Subscription;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class SubscriptionPlanSample : Sample
    {
        [Test]
        public void Should_Create_Plan()
        {
            string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            CreatePlanRequest request = new CreatePlanRequest()
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
                ProductReferenceCode = "productReferenceCode"
            };

            ResponseData<PlanResource> response = Plan.Create(request, options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.AreEqual($"plan-name-{randomString}",response.Data.Name);
            Assert.AreEqual( Currency.TRY.ToString(),response.Data.CurrencyCode);
            Assert.AreEqual( "productReferenceCode",response.Data.ProductReferenceCode);
            Assert.AreEqual( PaymentInterval.WEEKLY.ToString(),response.Data.PaymentInterval);
            Assert.AreEqual( 1,response.Data.PaymentIntervalCount);
            Assert.AreEqual( 3,response.Data.TrialPeriodDays);
            Assert.AreEqual( PlanPaymentType.RECURRING.ToString(),response.Data.PlanPaymentType);
            Assert.AreEqual( 12,response.Data.RecurrenceCount);
            Assert.AreEqual( "ACTIVE",response.Data.Status);
            Assert.IsNotNull(response.Data.ReferenceCode);
            Assert.IsNotNull(response.Data.CreatedDate);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_Update_Plan()
        {
            string randomString = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            UpdatePlanRequest request = new UpdatePlanRequest()
            {
                Locale = Locale.TR.ToString(),
                Name = $"updated-plan-name-{randomString}",
                ConversationId = "123456789",
                TrialPeriodDays = 5,
                PricingPlanReferenceCode = "pricingPlanReferenceCode"
            };
            
            ResponseData<PlanResource> response = Plan.Update(request, options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.AreEqual($"updated-plan-name-{randomString}",response.Data.Name);
            Assert.AreEqual( Currency.TRY.ToString(),response.Data.CurrencyCode);
            Assert.AreEqual( 5,response.Data.TrialPeriodDays);
            Assert.AreEqual( 12,response.Data.RecurrenceCount);
            Assert.IsNotNull(response.Data.ReferenceCode);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_Delete_Plan()
        {
            DeletePlanRequest request = new DeletePlanRequest
            {
                Locale = Locale.TR.ToString(),
                ConversationId = "123456789",
                PricingPlanReferenceCode = "pricingPlanReferenceCode"
            };
            
            IyzipayResourceV2 response = Plan.Delete(request, options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_Retrieve_Plan()
        {
            RetrievePlanRequest request = new RetrievePlanRequest()
            {
                Locale = Locale.TR.ToString(),
                ConversationId = "123456789",
                PricingPlanReferenceCode = "pricingPlanReferenceCode"
            };
            
            ResponseData<PlanResource> response = Plan.Retrieve(request, options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.AreEqual( Currency.TRY.ToString(),response.Data.CurrencyCode);
            Assert.IsNotNull(response.Data.ReferenceCode);
            Assert.IsNotNull(response.Data.CreatedDate);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
        
        [Test]
        public void Should_RetrieveAll_Plan()
        {
            RetrieveAllPlanRequest request = new RetrieveAllPlanRequest
            {
                Locale = Locale.TR.ToString(),
                ConversationId = "123456789",
                ProductReferenceCode = "productReferenceCode",
                Count = 1,
                Page = 1
            };
            
            ResponsePagingData<PlanResource> response = Plan.RetrieveAll(request, options);
            PrintResponse(response);
            
            Assert.AreEqual(response.Status,Status.SUCCESS.ToString());
            Assert.AreEqual(1,response.Data.Items.Count);
            Assert.AreEqual(1, response.Data.CurrentPage);
            Assert.IsNotNull(response.SystemTime);
            Assert.Null(response.ErrorMessage);
        }
    }
}