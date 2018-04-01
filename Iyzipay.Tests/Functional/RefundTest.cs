using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using Iyzipay.Tests.Functional.Util;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class RefundTest : BaseTest
    {
        [Test]
        public void Should_Refund_Payment()
        {
            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment payment = Payment.Create(paymentRequest, Options);

            CreateRefundRequest request = new CreateRefundRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = payment.PaymentItems[0].PaymentTransactionId;
            request.Price = "0.2";
            request.Currency = Currency.TRY.ToString();
            request.Ip = "85.34.78.112";

            Refund refund = Refund.Create(request, Options);

            PrintResponse(refund);

            Assert.AreEqual(Status.SUCCESS.ToString(), refund.Status);
            Assert.AreEqual(Locale.TR.ToString(), refund.Locale);
            Assert.AreEqual("123456789", refund.ConversationId);
            Assert.AreEqual(payment.PaymentId, refund.PaymentId);
            Assert.AreEqual(payment.PaymentItems[0].PaymentTransactionId, refund.PaymentTransactionId);
            Assert.AreEqual("0.2", refund.Price.RemoveTrailingZeros());
            Assert.NotNull(refund.SystemTime);
            Assert.Null(refund.ErrorCode);
            Assert.Null(refund.ErrorMessage);
            Assert.Null(refund.ErrorGroup);
        }

        [Test]
        public void Should_Refund_Fraudulent_Payment()
        {
            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment payment = Payment.Create(paymentRequest, Options);

            CreateRefundRequest request = new CreateRefundRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = payment.PaymentItems[0].PaymentTransactionId;
            request.Price = "0.2";
            request.Currency = Currency.TRY.ToString();
            request.Ip = "85.34.78.112";
            request.Reason = RefundReason.FRAUD.ToString();
            request.Description = "stolen card request with 11000 try payment for default sample";

            Refund refund = Refund.Create(request, Options);

            PrintResponse(refund);

            Assert.AreEqual(Status.SUCCESS.ToString(), refund.Status);
            Assert.AreEqual(Locale.TR.ToString(), refund.Locale);
            Assert.AreEqual("123456789", refund.ConversationId);
            Assert.AreEqual(payment.PaymentId, refund.PaymentId);
            Assert.AreEqual(payment.PaymentItems[0].PaymentTransactionId, refund.PaymentTransactionId);
            Assert.AreEqual("0.2", refund.Price.RemoveTrailingZeros());
            Assert.NotNull(refund.SystemTime);
            Assert.Null(refund.ErrorCode);
            Assert.Null(refund.ErrorMessage);
            Assert.Null(refund.ErrorGroup);
        }
    }
}
