using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class BasicThreedsPreAuthSample : Sample
    {
        [TestMethod]
        public void Should_Initialize_Threeds_With_Card()
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
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";
            request.Currency = Currency.TRY.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            BasicThreedsInitializePreAuth basicThreeDSInitializePreAuth = BasicThreedsInitializePreAuth.Create(request, options);

            PrintResponse<BasicThreedsInitializePreAuth>(basicThreeDSInitializePreAuth);

            Assert.IsNotNull(basicThreeDSInitializePreAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicThreeDSInitializePreAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicThreeDSInitializePreAuth.Locale);
            Assert.AreEqual("123456789", basicThreeDSInitializePreAuth.ConversationId);
        }

        [TestMethod]
        public void Should_Initialize_Threeds_With_Card_Token()
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
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";
            request.Currency = Currency.TRY.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardToken = "card token";
            paymentCard.CardUserKey = "card user key";
            request.PaymentCard = paymentCard;

            BasicThreedsInitializePreAuth basicThreeDSInitializePreAuth = BasicThreedsInitializePreAuth.Create(request, options);

            PrintResponse<BasicThreedsInitializePreAuth>(basicThreeDSInitializePreAuth);

            Assert.IsNotNull(basicThreeDSInitializePreAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicThreeDSInitializePreAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicThreeDSInitializePreAuth.Locale);
            Assert.AreEqual("123456789", basicThreeDSInitializePreAuth.ConversationId);
        }

        [TestMethod]
        public void Should_Auth_Threeds()
        {
            CreateThreedsPaymentRequest request = new CreateThreedsPaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentId = "12345";

            BasicThreedsPayment basicThreedsPayment = BasicThreedsPayment.Create(request, options);

            PrintResponse<BasicThreedsPayment>(basicThreedsPayment);

            Assert.IsNotNull(basicThreedsPayment.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicThreedsPayment.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicThreedsPayment.Locale);
            Assert.AreEqual("123456789", basicThreedsPayment.ConversationId);
        }
    }
}
