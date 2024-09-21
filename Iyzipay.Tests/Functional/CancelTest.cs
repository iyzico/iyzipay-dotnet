using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using Iyzipay.Tests.Functional.Util;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class CancelTest : BaseTest
    {
        [Test]
        public async Task Should_Cancel_PaymentAsync()
        {
            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment payment = await Payment.Create(paymentRequest, _options);

            CreateCancelRequest cancelRequest = CreateCancelRequestBuilder.Create()
                .PaymentId(payment.PaymentId)
                .Build();

            Cancel cancel = await Cancel.Create(cancelRequest, _options);

            PrintResponse(cancel);

            Assert.AreEqual(Locale.TR.ToString(), cancel.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(payment.PaymentId, cancel.PaymentId);
            Assert.AreEqual("1.1", cancel.Price.RemoveTrailingZeros());
            Assert.AreEqual(Currency.TRY.ToString(), cancel.Currency);
            Assert.NotNull(cancel.SystemTime);
            Assert.Null(cancel.ErrorMessage);
        }

        [Test]
        public async Task Should_Cancel_Fraudulent_PaymentAsync()
        {
            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .StandardListingPayment()
                .Build();

            Payment payment = await Payment.Create(paymentRequest, _options);

            CreateCancelRequest cancelRequest = CreateCancelRequestBuilder.Create()
                .PaymentId(payment.PaymentId)
                .Build();

            cancelRequest.Reason = RefundReason.FRAUD.ToString();
            cancelRequest.Description = "stolen card request with 11000 try payment for default sample";

            Cancel cancel = await Cancel.Create(cancelRequest, _options);

            PrintResponse(cancel);

            Assert.AreEqual(Locale.TR.ToString(), cancel.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(payment.PaymentId, cancel.PaymentId);
            Assert.AreEqual("1.1", cancel.Price.RemoveTrailingZeros());
            Assert.AreEqual(Currency.TRY.ToString(), cancel.Currency);
            Assert.NotNull(cancel.SystemTime);
            Assert.Null(cancel.ErrorMessage);
        }
    }
}
