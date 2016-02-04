using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ConnectThreeDSSample : Sample
    {
        [TestMethod]
        public void Should_Initialize_Threeds_With_Card()
        {
            CreateConnectThreeDSInitializeRequest request = new CreateConnectThreeDSInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BuyerEmail = "email@email.com";
            request.BuyerId = "B2323";
            request.BuyerIp = "127.0.0.1";
            request.ConnectorName = "ISBANK";
            request.Installment = 1;
            request.PaidPrice = "1.0";
            request.Price = "1.0";
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            ConnectThreeDSInitialize connectThreeDSInitialize = ConnectThreeDSInitialize.Create(request, options);

            PrintResponse<ConnectThreeDSInitialize>(connectThreeDSInitialize);

            Assert.IsNotNull(connectThreeDSInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectThreeDSInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectThreeDSInitialize.Locale);
            Assert.AreEqual("123456789", connectThreeDSInitialize.ConversationId);
        }

        [TestMethod]
        public void Should_Initialize_Threeds_With_Card_Token()
        {
            CreateConnectThreeDSInitializeRequest request = new CreateConnectThreeDSInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.BuyerEmail = "email@email.com";
            request.BuyerId = "B2323";
            request.BuyerIp = "127.0.0.1";
            request.ConnectorName = "connector name";
            request.Installment = 1;
            request.PaidPrice = "1.0";
            request.Price = "1.0";
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardToken = "card token";
            paymentCard.CardUserKey = "card user key";
            request.PaymentCard = paymentCard;

            ConnectThreeDSInitialize connectThreeDSInitialize = ConnectThreeDSInitialize.Create(request, options);

            PrintResponse<ConnectThreeDSInitialize>(connectThreeDSInitialize);

            Assert.IsNotNull(connectThreeDSInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectThreeDSInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectThreeDSInitialize.Locale);
            Assert.AreEqual("123456789", connectThreeDSInitialize.ConversationId);
        }

        [TestMethod]
        public void Should_Auth_Threeds()
        {
            CreateConnectThreeDSAuthRequest request = new CreateConnectThreeDSAuthRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentId = "12345";

            ConnectThreeDSAuth connectThreeDSAuth = ConnectThreeDSAuth.Create(request, options);

            PrintResponse<ConnectThreeDSAuth>(connectThreeDSAuth);

            Assert.IsNotNull(connectThreeDSAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectThreeDSAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectThreeDSAuth.Locale);
            Assert.AreEqual("123456789", connectThreeDSAuth.ConversationId);
        }
    }
}
