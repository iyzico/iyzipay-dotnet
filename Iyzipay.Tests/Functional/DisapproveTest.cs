using System;
using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class DisapproveTest : BaseTest
    {
        [Test]
        public void Should_Disapprove_Payment()
        {
            CreateSubMerchantRequest request = CreateSubMerchantRequestBuilder.Create()
                .PersonalSubMerchantRequest()
                .Build();

            SubMerchant subMerchant = SubMerchant.Create(request, _options);

            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .MarketplacePayment(subMerchant.SubMerchantKey)
                .Build();

            Payment payment = Payment.Create(paymentRequest, _options);

            String paymentTransactionId = payment.PaymentItems[0].PaymentTransactionId;

            CreateApprovalRequest approvalRequest = CreateApprovalRequestBuilder.Create()
                .PaymentTransactionId(paymentTransactionId)
                .Build();

            Approval.Create(approvalRequest, _options);

            Disapproval disapproval = Disapproval.Create(approvalRequest, _options);

            PrintResponse(disapproval);

            Assert.AreEqual(paymentTransactionId, disapproval.PaymentTransactionId);
            Assert.AreEqual(Status.SUCCESS.ToString(), disapproval.Status);
            Assert.AreEqual(Locale.TR.ToString(), disapproval.Locale);
            Assert.NotNull(disapproval.SystemTime);
            Assert.Null(disapproval.ErrorCode);
            Assert.Null(disapproval.ErrorMessage);
            Assert.Null(disapproval.ErrorGroup);
        }
    }
}
