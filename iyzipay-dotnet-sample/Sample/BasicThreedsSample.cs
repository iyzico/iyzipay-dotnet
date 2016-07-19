// <copyright file="BasicThreedsSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Basic 3D-secure sample
    /// </summary>
    /// <seealso cref="IyzipaySample.Sample.Sample" />
    /// <summary>
    /// BasicThreedsSample
    /// </summary>
    [TestClass]
    public class BasicThreedsSample : Sample
    {
        /// <summary>
        /// Initializes 3D-secure with card
        /// </summary>
        [TestMethod]
        public void ShouldInitializeThreedsWithCard()
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
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";
            request.Currency = Currency.TRY.ToString();

            var paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            var basicThreeDSInitialize = BasicThreedsInitialize.Create(request, Options);

            this.PrintResponse<BasicThreedsInitialize>(basicThreeDSInitialize);

            Assert.IsNotNull(basicThreeDSInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicThreeDSInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicThreeDSInitialize.Locale);
            Assert.AreEqual("123456789", basicThreeDSInitialize.ConversationId);
        }

        /// <summary>
        /// Should initialize 3D-secure with card token.
        /// </summary>
        [TestMethod]
        public void ShouldInitializeThreedsWithCardToken()
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
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";
            request.Currency = Currency.TRY.ToString();

            var paymentCard = new PaymentCard();
            paymentCard.CardToken = "card token";
            paymentCard.CardUserKey = "card user key";
            request.PaymentCard = paymentCard;

            var basicThreeDSInitialize = BasicThreedsInitialize.Create(request, Options);

            this.PrintResponse<BasicThreedsInitialize>(basicThreeDSInitialize);

            Assert.IsNotNull(basicThreeDSInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicThreeDSInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicThreeDSInitialize.Locale);
            Assert.AreEqual("123456789", basicThreeDSInitialize.ConversationId);
        }

        /// <summary>
        /// Should authorize 3D-secure.
        /// </summary>
        [TestMethod]
        public void ShouldAuthThreeds()
        {
            var request = new CreateThreedsPaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentId = "12345";

            var basicThreeDS = BasicThreedsPayment.Create(request, Options);

            this.PrintResponse<BasicThreedsPayment>(basicThreeDS);

            Assert.IsNotNull(basicThreeDS.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicThreeDS.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicThreeDS.Locale);
            Assert.AreEqual("123456789", basicThreeDS.ConversationId);
        }
    }
}
