using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class RefundSample : Sample
    {
        [Test]
        public async Task Should_RefundAsync()
        {
            CreateRefundRequest request = new CreateRefundRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.ToString();
            request.PaymentTransactionId = "1";
            request.Price = "0.5";
            request.Ip = "85.34.78.112";
            request.Currency = Currency.TRY.ToString();

            Refund refund = await Refund.Create(request, options);

            PrintResponse<Refund>(refund);

            Assert.AreEqual(Status.SUCCESS.ToString(), refund.Status);
            Assert.AreEqual(Locale.TR.ToString(), refund.Locale);
            Assert.AreEqual("123456789", refund.ConversationId);
            Assert.IsNotNull(refund.SystemTime);
            Assert.IsNull(refund.ErrorCode);
            Assert.IsNull(refund.ErrorMessage);
            Assert.IsNull(refund.ErrorGroup);
        }

        [Test]
        public async Task Should_Amount_Based_RefundAsync()
        {
            CreateAmountBasedRefundRequest request = new CreateAmountBasedRefundRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "--";
            request.Ip = "85.34.78.112";
            request.Price = "2";
            request.PaymentId = "12425590";

            Refund amountBasedRefund = await Refund.CreateAmountBasedRefundRequest(request, options);

            PrintResponse<Refund>(amountBasedRefund);

            Assert.AreEqual(Status.SUCCESS.ToString(), amountBasedRefund.Status);
            Assert.AreEqual("10", amountBasedRefund.Price);
            Assert.AreEqual(Locale.TR.ToString(), amountBasedRefund.Locale);
            Assert.AreEqual("--", amountBasedRefund.ConversationId);
            Assert.IsNotNull(amountBasedRefund.SystemTime);
            Assert.IsNull(amountBasedRefund.ErrorCode);
            Assert.IsNull(amountBasedRefund.ErrorMessage);
            Assert.IsNull(amountBasedRefund.ErrorGroup);
        }


        public async Task Should_Refund_With_Reason_And_DescriptionAsync()
        {
            CreateRefundRequest request = new CreateRefundRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.ToString();
            request.PaymentTransactionId = "1";
            request.Price = "0.5";
            request.Ip = "85.34.78.112";
            request.Currency = Currency.TRY.ToString();
            request.Reason = RefundReason.OTHER.ToString();
            request.Description = "customer requested for default sample";

            Refund refund = await Refund.Create(request, options);

            PrintResponse<Refund>(refund);

            Assert.AreEqual(Status.SUCCESS.ToString(), refund.Status);
            Assert.AreEqual(Locale.TR.ToString(), refund.Locale);
            Assert.AreEqual("123456789", refund.ConversationId);
            Assert.IsNotNull(refund.SystemTime);
            Assert.IsNull(refund.ErrorCode);
            Assert.IsNull(refund.ErrorMessage);
            Assert.IsNull(refund.ErrorGroup);
        }

    }
}
