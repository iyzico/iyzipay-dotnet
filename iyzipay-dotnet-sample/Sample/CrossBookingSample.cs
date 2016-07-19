// <copyright file="CrossBookingSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Cross-booking sample
    /// </summary>
    [TestClass]
    public class CrossBookingSample : Sample
    {
        /// <summary>
        /// Should send money to sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldSendMoneyToSubMerchant()
        {
            var request = new CreateCrossBookingRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "sub merchant key";
            request.Price = "1";
            request.Reason = "reason text";
            request.Currency = Currency.TRY.ToString();

            var crossBookingToSubMerchant = CrossBookingToSubMerchant.Create(request, Options);

            this.PrintResponse<CrossBookingToSubMerchant>(crossBookingToSubMerchant);

            Assert.IsNotNull(crossBookingToSubMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), crossBookingToSubMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), crossBookingToSubMerchant.Locale);
            Assert.AreEqual("123456789", crossBookingToSubMerchant.ConversationId);
        }

        /// <summary>
        /// Should receive money from sub merchant.
        /// </summary>
        [TestMethod]
        public void ShouldReceiveMoneyFromSubMerchant()
        {
            var request = new CreateCrossBookingRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "sub merchant key";
            request.Price = "1";
            request.Reason = "reason text";
            request.Currency = Currency.TRY.ToString();

            var crossBookingFromSubMerchant = CrossBookingFromSubMerchant.Create(request, Options);

            this.PrintResponse<CrossBookingFromSubMerchant>(crossBookingFromSubMerchant);

            Assert.IsNotNull(crossBookingFromSubMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), crossBookingFromSubMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), crossBookingFromSubMerchant.Locale);
            Assert.AreEqual("123456789", crossBookingFromSubMerchant.ConversationId);
        }
    }
}
