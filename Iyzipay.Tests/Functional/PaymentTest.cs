﻿using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder;
using Iyzipay.Tests.Functional.Builder.Request;
using Iyzipay.Tests.Functional.Util;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class PaymentTest : BaseTest
    {
        [Test]
        public async Task Should_Create_Listing_PaymentAsync()
        {
            CreatePaymentRequest request = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment payment = await Payment.Create(request, _options);

            PrintResponse(payment);

            Assert.Null(payment.ConnectorName);
            Assert.AreEqual(Locale.TR.ToString(), payment.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), payment.Status);
            Assert.NotNull(payment.SystemTime);
            Assert.Null(payment.ErrorMessage);
            Assert.NotNull(payment.PaymentId);
            Assert.NotNull(payment.BasketId);
            Assert.AreEqual(payment.Price, "1");
            Assert.AreEqual(payment.PaidPrice, "1.1");
            Assert.AreEqual(payment.IyziCommissionRateAmount.RemoveTrailingZeros(), "0.028875");
            Assert.AreEqual(payment.IyziCommissionFee.RemoveTrailingZeros(), "0.25");
            Assert.AreEqual(payment.MerchantCommissionRate.RemoveTrailingZeros(), "10");
            Assert.AreEqual(payment.MerchantCommissionRateAmount.RemoveTrailingZeros(), "0.1");
        }

        [Test]
        public async Task Should_Create_Marketplace_PaymentAsync()
        {
            CreateSubMerchantRequest createSubMerchantRequest = CreateSubMerchantRequestBuilder.Create()
                .PersonalSubMerchantRequest()
                .Build();

            string subMerchantKey = (await SubMerchant.Create(createSubMerchantRequest, _options)).SubMerchantKey;
            CreatePaymentRequest request = CreatePaymentRequestBuilder.Create()
                .MarketplacePayment(subMerchantKey)
                .Build();

            Payment payment = await Payment.Create(request, _options);

            PrintResponse(payment);

            Assert.Null(payment.ConnectorName);
            Assert.AreEqual(Locale.TR.ToString(), payment.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), payment.Status);
            Assert.NotNull(payment.SystemTime);
            Assert.Null(payment.ErrorMessage);
            Assert.NotNull(payment.PaymentId);
            Assert.NotNull(payment.BasketId);
            Assert.AreEqual("1", payment.Price);
            Assert.AreEqual("1.1", payment.PaidPrice);
            Assert.AreEqual("0.028875", payment.IyziCommissionRateAmount.RemoveTrailingZeros());
            Assert.AreEqual("0.25", payment.IyziCommissionFee.RemoveTrailingZeros());
            Assert.AreEqual("10", payment.MerchantCommissionRate.RemoveTrailingZeros());
            Assert.AreEqual("0.1", payment.MerchantCommissionRateAmount.RemoveTrailingZeros());
            Assert.AreEqual(1, payment.Installment);
        }

        [Test]
        public async Task Should_Create_Payment_With_Registered_CardAsync()
        {
            string externalUserId = RandomGenerator.RandomId;
            CardInformation cardInformation = CardInformationBuilder.Create()
                .Build();

            CreateCardRequest cardRequest = CreateCardRequestBuilder.Create()
                .Card(cardInformation)
                .ExternalId(externalUserId)
                .Email("email@email.com")
                .Build();

            Card card = await Card.Create(cardRequest, _options);

            PaymentCard paymentCard = PaymentCardBuilder.Create()
                .CardUserKey(card.CardUserKey)
                .CardToken(card.CardToken)
                .Build();

            CreatePaymentRequest request = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .PaymentCard(paymentCard)
                .Build();

            Payment payment = await Payment.Create(request, _options);

            PrintResponse(payment);

            Assert.Null(payment.ConnectorName);
            Assert.AreEqual(Locale.TR.ToString(), payment.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), payment.Status);
            Assert.NotNull(payment.SystemTime);
            Assert.AreEqual("123456789", payment.ConversationId);
            Assert.Null(payment.ErrorMessage);
            Assert.NotNull(payment.PaymentId);
            Assert.NotNull(payment.BasketId);
            Assert.AreEqual("1", payment.Price);
            Assert.AreEqual("1.1", payment.PaidPrice.RemoveTrailingZeros());
            Assert.AreEqual("0.028875", payment.IyziCommissionRateAmount.RemoveTrailingZeros());
            Assert.AreEqual("0.25", payment.IyziCommissionFee.RemoveTrailingZeros());
            Assert.AreEqual("10", payment.MerchantCommissionRate.RemoveTrailingZeros());
            Assert.AreEqual("0.1", payment.MerchantCommissionRateAmount.RemoveTrailingZeros());
            Assert.AreEqual(1, payment.Installment);
        }

        [Test]
        public async Task Should_Retrieve_PaymentAsync()
        {
            CreatePaymentRequest request = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment createdPayment = await Payment.Create(request, _options);

            PrintResponse(createdPayment);

            RetrievePaymentRequest retrievePaymentRequest = new RetrievePaymentRequest();
            retrievePaymentRequest.Locale = Locale.TR.ToString();
            retrievePaymentRequest.ConversationId = "123456789";
            retrievePaymentRequest.PaymentId = createdPayment.PaymentId;

            Payment payment = await Payment.Retrieve(retrievePaymentRequest, _options);

            Assert.AreEqual(Locale.TR.ToString(), payment.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), payment.Status);
            Assert.AreEqual(1, payment.Installment);
            Assert.AreEqual("123456789", payment.ConversationId);
            Assert.AreEqual(createdPayment.PaymentId, payment.PaymentId);
            Assert.NotNull(payment.SystemTime);
            Assert.Null(payment.ErrorMessage);
            Assert.NotNull(payment.BasketId);
        }

        [Test]
        public async Task Should_Create_Payment_With_Loyalty_Ykb_WorldAsync()
        {
            LoyaltyReward reward = new LoyaltyReward();
            reward.RewardUsage = 1;
            reward.RewardAmount = "0.1";

            CreatePaymentRequest request = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Reward(reward)
                .PaymentCard(PaymentCardBuilder.Create().BuildWithYKBCardCredentials().Build())
                .Build();

            Payment payment = await Payment.Create(request, _options);

            PrintResponse(payment);

            Assert.Null(payment.ConnectorName);
            Assert.AreEqual(Locale.TR.ToString(), payment.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), payment.Status);
            Assert.NotNull(payment.SystemTime);
            Assert.Null(payment.ErrorMessage);
            Assert.NotNull(payment.PaymentId);
            Assert.NotNull(payment.BasketId);
            Assert.AreEqual(payment.Price, "1");
            Assert.AreEqual(payment.PaidPrice, "1.1");
            Assert.AreEqual(payment.IyziCommissionRateAmount.RemoveTrailingZeros(), "0.028875");
            Assert.AreEqual(payment.IyziCommissionFee.RemoveTrailingZeros(), "0.25");
            Assert.AreEqual(payment.MerchantCommissionRate.RemoveTrailingZeros(), "10");
            Assert.AreEqual(payment.MerchantCommissionRateAmount.RemoveTrailingZeros(), "0.1");
        }

        [Test]
        public async Task Should_Create_Payment_With_Loyalty_Denizbank_BonusAsync()
        {
            LoyaltyReward reward = new LoyaltyReward();
            reward.RewardUsage = 1;
            reward.RewardAmount = "0.1";

            CreatePaymentRequest request = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Reward(reward)
                .PaymentCard(PaymentCardBuilder.Create().BuildWithDenizBankCardCredentials().Build())
                .Build();

            Payment payment = await Payment.Create(request, _options);

            PrintResponse(payment);

            Assert.Null(payment.ConnectorName);
            Assert.AreEqual(Locale.TR.ToString(), payment.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), payment.Status);
            Assert.NotNull(payment.SystemTime);
            Assert.Null(payment.ErrorMessage);
            Assert.NotNull(payment.PaymentId);
            Assert.NotNull(payment.BasketId);
            Assert.AreEqual(payment.Price, "1");
            Assert.AreEqual(payment.PaidPrice, "1.1");
            Assert.AreEqual(payment.IyziCommissionRateAmount.RemoveTrailingZeros(), "0.028875");
            Assert.AreEqual(payment.IyziCommissionFee.RemoveTrailingZeros(), "0.25");
            Assert.AreEqual(payment.MerchantCommissionRate.RemoveTrailingZeros(), "10");
            Assert.AreEqual(payment.MerchantCommissionRateAmount.RemoveTrailingZeros(), "0.1");
        }
    }
}