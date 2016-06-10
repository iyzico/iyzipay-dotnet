using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class BasicPaymentSample : Sample
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

            BasicPayment basicPaymentAuth = BasicPayment.Create(request, options);

            PrintResponse<BasicPayment>(basicPaymentAuth);

            Assert.IsNotNull(basicPaymentAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicPaymentAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicPaymentAuth.Locale);
            Assert.AreEqual("123456789", basicPaymentAuth.ConversationId);
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

            BasicPayment basicPaymentAuth = BasicPayment.Create(request, options);

            PrintResponse<BasicPayment>(basicPaymentAuth);

            Assert.IsNotNull(basicPaymentAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicPaymentAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicPaymentAuth.Locale);
            Assert.AreEqual("123456789", basicPaymentAuth.ConversationId);
        }
    }
}
