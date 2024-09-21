using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using Iyzipay.Tests.Functional.Util;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class RefundTest : BaseTest
    {
        [Test]
        public async Task Should_Refund_PaymentAsync()
        {
            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment payment = await Payment.Create(paymentRequest, _options);

            CreateRefundRequest request = new CreateRefundRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = payment.PaymentItems[0].PaymentTransactionId;
            request.Price = "0.2";
            request.Currency = Currency.TRY.ToString();
            request.Ip = "85.34.78.112";

            Refund refund = await Refund.Create(request, _options);

            PrintResponse(refund);

            Assert.AreEqual(Status.SUCCESS.ToString(), refund.Status);
            Assert.AreEqual(Locale.TR.ToString(), refund.Locale);
            Assert.AreEqual("123456789", refund.ConversationId);
            Assert.AreEqual(payment.PaymentId, refund.PaymentId);
            Assert.AreEqual(payment.PaymentItems[0].PaymentTransactionId, refund.PaymentTransactionId);
            Assert.AreEqual("0.2", refund.Price.RemoveTrailingZeros());
            Assert.NotNull(refund.SystemTime);
            Assert.Null(refund.ErrorMessage);
        }

        [Test]
        public async Task Should_Refund_Fraudulent_PaymentAsync()
        {
            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment payment = await Payment.Create(paymentRequest, _options);

            CreateRefundRequest request = new CreateRefundRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = payment.PaymentItems[0].PaymentTransactionId;
            request.Price = "0.2";
            request.Currency = Currency.TRY.ToString();
            request.Ip = "85.34.78.112";
            request.Reason = RefundReason.FRAUD.ToString();
            request.Description = "stolen card request with 11000 try payment for default sample";

            Refund refund = await Refund.Create(request, _options);

            PrintResponse(refund);

            Assert.AreEqual(Status.SUCCESS.ToString(), refund.Status);
            Assert.AreEqual(Locale.TR.ToString(), refund.Locale);
            Assert.AreEqual("123456789", refund.ConversationId);
            Assert.AreEqual(payment.PaymentId, refund.PaymentId);
            Assert.AreEqual(payment.PaymentItems[0].PaymentTransactionId, refund.PaymentTransactionId);
            Assert.AreEqual("0.2", refund.Price.RemoveTrailingZeros());
            Assert.NotNull(refund.SystemTime);
            Assert.Null(refund.ErrorMessage);
        }
    }
}
