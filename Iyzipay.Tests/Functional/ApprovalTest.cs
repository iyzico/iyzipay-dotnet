using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class ApprovalTest : BaseTest
    {
        [Test]
        public async Task Should_Approve_Payment_ItemAsync()
        {
            CreateSubMerchantRequest request = CreateSubMerchantRequestBuilder.Create()
                .PersonalSubMerchantRequest()
                .Build();

            SubMerchant subMerchant = await SubMerchant.Create(request, _options);

            CreatePaymentRequest paymentRequest = CreatePaymentRequestBuilder.Create()
                .MarketplacePayment(subMerchant.SubMerchantKey)
                .Build();

            Payment payment = await Payment.Create(paymentRequest, _options);
            string paymentTransactionId = payment.PaymentItems[0].PaymentTransactionId;

            CreateApprovalRequest approvalRequest = CreateApprovalRequestBuilder.Create()
                .PaymentTransactionId(paymentTransactionId)
                .Build();

            Approval approval = await Approval.Create(approvalRequest, _options);

            Assert.AreEqual(paymentTransactionId, approval.PaymentTransactionId);
            Assert.AreEqual(Locale.TR.ToString(), payment.Locale);
            Assert.AreEqual(Status.SUCCESS.ToString(), payment.Status);
            Assert.NotNull(payment.SystemTime);
            Assert.Null(payment.ErrorMessage);
        }
    }
}
