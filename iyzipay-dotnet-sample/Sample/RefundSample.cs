// <copyright file="RefundSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Refund sample
    /// </summary>
    [TestClass]
    public class RefundSample : Sample
    {
        /// <summary>
        /// Should refund.
        /// </summary>
        [TestMethod]
        public void ShouldRefund()
        {
            var request = new CreateRefundRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.PaymentTransactionId = "1";
            request.Price = "0.1";
            request.Ip = "85.34.78.112";
            request.Currency = Currency.TRY.ToString();

            var refund = Refund.Create(request, Options);

            this.PrintResponse<Refund>(refund);

            Assert.IsNotNull(refund.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), refund.Status);
            Assert.AreEqual(Locale.TR.GetName(), refund.Locale);
            Assert.AreEqual("123456789", refund.ConversationId);
        }

        /// <summary>
        /// Should refund charged from merchant.
        /// </summary>
        [TestMethod]
        public void ShouldRefundChargedFromMerchant()
        {
            var request = new CreateRefundRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.PaymentTransactionId = "1";
            request.Price = "0.1";
            request.Ip = "85.34.78.112";
            request.Currency = Currency.TRY.ToString();

            var refundChargedFromMerchant = RefundChargedFromMerchant.Create(request, Options);

            this.PrintResponse<RefundChargedFromMerchant>(refundChargedFromMerchant);

            Assert.IsNotNull(refundChargedFromMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), refundChargedFromMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), refundChargedFromMerchant.Locale);
            Assert.AreEqual("123456789", refundChargedFromMerchant.ConversationId);
        }
    }
}
