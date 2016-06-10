using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class BasicPostAuthSample : Sample
    {
        [TestMethod]
        public void Should_Post_Auth()
        {
            CreatePaymentPostAuthRequest request = new CreatePaymentPostAuthRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.PaymentId = "1";
            request.PaidPrice = "0.6";
            request.Ip = "85.34.78.112";
            request.Currency = Currency.TRY.ToString();

            BasicPaymentPostAuth basicPaymentPostAuth = BasicPaymentPostAuth.Create(request, options);

            PrintResponse<BasicPaymentPostAuth>(basicPaymentPostAuth);

            Assert.IsNotNull(basicPaymentPostAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicPaymentPostAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicPaymentPostAuth.Locale);
            Assert.AreEqual("123456789", basicPaymentPostAuth.ConversationId);
            Assert.AreEqual("1", basicPaymentPostAuth.PaymentId);
            Assert.AreEqual("0.6", basicPaymentPostAuth.PaidPrice);
        }
    }
}
