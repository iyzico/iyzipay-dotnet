// <copyright file="PaymentPostAuthSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Payment post authorization sample
    /// </summary>
    [TestClass]
    public class PaymentPostAuthSample : Sample
    {
        /// <summary>
        /// Should post authentication.
        /// </summary>
        [TestMethod]
        public void ShouldPostAuth()
        {
            var request = new CreatePaymentPostAuthRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.PaymentId = "1";
            request.PaidPrice = "0.6";
            request.Ip = "85.34.78.112";
            request.Currency = Currency.TRY.ToString();

            var paymentPostAuth = PaymentPostAuth.Create(request, Options);

            this.PrintResponse<PaymentPostAuth>(paymentPostAuth);

            Assert.IsNotNull(paymentPostAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), paymentPostAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), paymentPostAuth.Locale);
            Assert.AreEqual("123456789", paymentPostAuth.ConversationId);
            Assert.AreEqual("1", paymentPostAuth.PaymentId);
            Assert.AreEqual("0.6", paymentPostAuth.PaidPrice);
        }
    }
}
