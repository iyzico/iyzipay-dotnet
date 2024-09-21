using System;
using System.Threading.Tasks;
using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class DisapproveTest : BaseTest
    {
        [Test]
        public async Task Should_Disapprove_PaymentAsync()
        {
            CreateSubMerchantRequest request = CreateSubMerchantRequestBuilder.Create()
                .PersonalSubMerchantRequest()
                .Build();

            SubMerchant subMerchant = await SubMerchant.Create(request, _options);

            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .MarketplacePayment(subMerchant.SubMerchantKey)
                .Build();

            Payment payment = await Payment.Create(paymentRequest, _options);

            String paymentTransactionId = payment.PaymentItems[0].PaymentTransactionId;

            CreateApprovalRequest approvalRequest = CreateApprovalRequestBuilder.Create()
                .PaymentTransactionId(paymentTransactionId)
                .Build();

            await Approval.Create(approvalRequest, _options);

            Disapproval disapproval = await Disapproval .Create(approvalRequest, _options);

            PrintResponse(disapproval);

            Assert.AreEqual(paymentTransactionId, disapproval.PaymentTransactionId);
            Assert.AreEqual(Status.SUCCESS.ToString(), disapproval.Status);
            Assert.AreEqual(Locale.TR.ToString(), disapproval.Locale);
            Assert.NotNull(disapproval.SystemTime);
            Assert.Null(disapproval.ErrorMessage);
        }
    }
}
