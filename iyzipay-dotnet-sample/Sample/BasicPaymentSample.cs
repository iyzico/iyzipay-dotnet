// <copyright file="BasicPaymentSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Basic payment sample
    /// </summary>
    /// <seealso cref="IyzipaySample.Sample.Sample" />
    /// <summary>
    /// BasicPaymentSample
    /// </summary>
    [TestClass]
    public class BasicPaymentSample : Sample
    {
        /// <summary>
        /// Should pay with card.
        /// </summary>
        [TestMethod]
        public void ShouldPayWithCard()
        {
            var request = new CreateBasicPaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BuyerEmail = "email@email.com";
            request.BuyerId = "B2323";
            request.BuyerIp = "85.34.78.112";
            request.ConnectorName = "connector name";
            request.Installment = 1;
            request.PaidPrice = "1.0";
            request.Price = "1.0";
            request.Currency = Currency.TRY.ToString();

            var paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "212";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            var basicPaymentAuth = BasicPayment.Create(request, Options);

            this.PrintResponse<BasicPayment>(basicPaymentAuth);

            Assert.IsNotNull(basicPaymentAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicPaymentAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicPaymentAuth.Locale);
            Assert.AreEqual("123456789", basicPaymentAuth.ConversationId);
        }

        /// <summary>
        /// Should pay with card token
        /// </summary>
        [TestMethod]
        public void ShouldPayWithCardtoken()
        {
            var request = new CreateBasicPaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BuyerEmail = "email@email.com";
            request.BuyerId = "B2323";
            request.BuyerIp = "85.34.78.112";
            request.ConnectorName = "connector name";
            request.Installment = 1;
            request.PaidPrice = "1.0";
            request.Price = "1.0";
            request.Currency = Currency.TRY.ToString();

            var paymentCard = new PaymentCard();
            paymentCard.CardToken = "card token";
            paymentCard.CardUserKey = "card user key";
            request.PaymentCard = paymentCard;

            var basicPaymentAuth = BasicPayment.Create(request, Options);

            this.PrintResponse<BasicPayment>(basicPaymentAuth);

            Assert.IsNotNull(basicPaymentAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicPaymentAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicPaymentAuth.Locale);
            Assert.AreEqual("123456789", basicPaymentAuth.ConversationId);
        }
    }
}
