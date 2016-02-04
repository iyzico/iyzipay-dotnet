using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ConnectPaymentAuthSample : Sample
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
            request.ConnectorName = "ISBANK";
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

            ConnectPaymentAuth connectPaymentAuth = ConnectPaymentAuth.Create(request, options);

            PrintResponse<ConnectPaymentAuth>(connectPaymentAuth);

            Assert.IsNotNull(connectPaymentAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectPaymentAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectPaymentAuth.Locale);
            Assert.AreEqual("123456789", connectPaymentAuth.ConversationId);
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
            request.ConnectorName = "ISBANK";
            request.Installment = 1;
            request.PaidPrice = "1.0";
            request.Price = "1.0";

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardToken = "cardToken";
            paymentCard.CardUserKey = "cardUserKey";
            request.PaymentCard = paymentCard;

            ConnectPaymentAuth connectPaymentAuth = ConnectPaymentAuth.Create(request, options);

            PrintResponse<ConnectPaymentAuth>(connectPaymentAuth);

            Assert.IsNotNull(connectPaymentAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectPaymentAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectPaymentAuth.Locale);
            Assert.AreEqual("123456789", connectPaymentAuth.ConversationId);
        }
    }
}
