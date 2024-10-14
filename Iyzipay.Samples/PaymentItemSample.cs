using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class PaymentItemSample : Sample
    {
        [Test]
        public async Task Should_Update_Payment_ItemAsync()
        {
            UpdatePaymentItemRequest request = new UpdatePaymentItemRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "subMerchantKey";
            request.PaymentTransactionId = "transactionId";
            request.SubMerchantPrice = "price";

            PaymentItem paymentItem = await PaymentItem.Update(request, options);

            PrintResponse<PaymentItem>(paymentItem);

            Assert.AreEqual(Status.SUCCESS.ToString(), paymentItem.Status);
            Assert.AreEqual(Locale.TR.ToString(), paymentItem.Locale);
            Assert.AreEqual("123456789", paymentItem.ConversationId);
            Assert.IsNotNull(paymentItem.SystemTime);
            Assert.IsNull(paymentItem.ErrorMessage);
        }
    }
}
