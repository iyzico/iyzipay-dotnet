using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ConnectPaymentPreAuthSample : Sample
    {
        [TestMethod]
        public void Should_Pay_With_Card()
        {
            CreateConnectPaymentRequest request = new CreateConnectPaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BuyerEmail = "email@email.com";
            request.BuyerId = "B2323";
            request.BuyerIp = "127.0.0.1";
            request.ConnectorName = "connector name";
            request.Installment = 1;
            request.PaidPrice = "1.0";
            request.Price = "1.0";

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "212";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            ConnectPaymentPreAuth connectPaymentPreAuth = ConnectPaymentPreAuth.Create(request, options);

            PrintResponse<ConnectPaymentPreAuth>(connectPaymentPreAuth);

            Assert.IsNotNull(connectPaymentPreAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectPaymentPreAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectPaymentPreAuth.Locale);
            Assert.AreEqual("123456789", connectPaymentPreAuth.ConversationId);
        }

        [TestMethod]
        public void Should_Pay_With_Card_token()
        {
            CreateConnectPaymentRequest request = new CreateConnectPaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BuyerEmail = "email@email.com";
            request.BuyerId = "B2323";
            request.BuyerIp = "127.0.0.1";
            request.ConnectorName = "connector name";
            request.Installment = 1;
            request.PaidPrice = "1.0";
            request.Price = "1.0";

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardToken = "card token";
            paymentCard.CardUserKey = "card user key";
            request.PaymentCard = paymentCard;

            ConnectPaymentPreAuth connectPaymentPreAuth = ConnectPaymentPreAuth.Create(request, options);

            PrintResponse<ConnectPaymentPreAuth>(connectPaymentPreAuth);

            Assert.IsNotNull(connectPaymentPreAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectPaymentPreAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectPaymentPreAuth.Locale);
            Assert.AreEqual("123456789", connectPaymentPreAuth.ConversationId);
        }
    }
}
