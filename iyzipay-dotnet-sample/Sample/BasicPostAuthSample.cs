// <copyright file="BasicPostAuthSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Basic post authorization sample
    /// </summary>
    /// <seealso cref="IyzipaySample.Sample.Sample" />
    /// <summary>
    /// BasicPostAuthSample
    /// </summary>
    [TestClass]
    public class BasicPostAuthSample : Sample
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

            var basicPaymentPostAuth = BasicPaymentPostAuth.Create(request, Options);

            this.PrintResponse<BasicPaymentPostAuth>(basicPaymentPostAuth);

            Assert.IsNotNull(basicPaymentPostAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicPaymentPostAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicPaymentPostAuth.Locale);
            Assert.AreEqual("123456789", basicPaymentPostAuth.ConversationId);
            Assert.AreEqual("1", basicPaymentPostAuth.PaymentId);
            Assert.AreEqual("0.6", basicPaymentPostAuth.PaidPrice);
        }
    }
}
