using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class BasicPaymentPreAuthSample : Sample
    {
        [TestMethod]
        public void Should_Pay_With_Card()
        {
            CreateBasicPaymentRequest request = new CreateBasicPaymentRequest();
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

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "212";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            BasicPaymentPreAuth BasicPaymentPreAuth = BasicPaymentPreAuth.Create(request, options);

            PrintResponse<BasicPaymentPreAuth>(BasicPaymentPreAuth);

            Assert.IsNotNull(BasicPaymentPreAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), BasicPaymentPreAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), BasicPaymentPreAuth.Locale);
            Assert.AreEqual("123456789", BasicPaymentPreAuth.ConversationId);
        }

        [TestMethod]
        public void Should_Pay_With_Card_token()
        {
            CreateBasicPaymentRequest request = new CreateBasicPaymentRequest();
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

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardToken = "card token";
            paymentCard.CardUserKey = "card user key";
            request.PaymentCard = paymentCard;

            BasicPaymentPreAuth BasicPaymentPreAuth = BasicPaymentPreAuth.Create(request, options);

            PrintResponse<BasicPaymentPreAuth>(BasicPaymentPreAuth);

            Assert.IsNotNull(BasicPaymentPreAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), BasicPaymentPreAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), BasicPaymentPreAuth.Locale);
            Assert.AreEqual("123456789", BasicPaymentPreAuth.ConversationId);
        }
    }
}
