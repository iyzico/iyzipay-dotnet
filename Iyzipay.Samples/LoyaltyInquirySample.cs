using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class LoyaltyInquirySample : Sample
    {
        [Test]
        public async Task Should_Inquire_LoyaltyAsync()
        {
            LoyaltyInquiryRequest request = new LoyaltyInquiryRequest();
            LoyaltyPaymentCard loyaltyPaymentCard = new LoyaltyPaymentCard();
            loyaltyPaymentCard.CardHolderName = "John Doe";
            loyaltyPaymentCard.CardNumber = "5528790000000008";
            loyaltyPaymentCard.ExpireYear = "2030";
            loyaltyPaymentCard.ExpireMonth = "12";
            loyaltyPaymentCard.Cvc = "123";
            loyaltyPaymentCard.CardUserKey = "card user key";
            loyaltyPaymentCard.CardToken =  "card token";

            request.ConversationId = "123456789";
            request.PaymentCard = loyaltyPaymentCard;
            request.Currency = "TRY";

            LoyaltyInquiry loyaltyInquiry = await LoyaltyInquiry.Create(request, options);

            PrintResponse<LoyaltyInquiry>(loyaltyInquiry);

            Assert.AreEqual(Status.SUCCESS.ToString(), loyaltyInquiry.Status);
            Assert.AreEqual(Locale.TR.ToString(), loyaltyInquiry.Locale);
            Assert.AreEqual("123456789", loyaltyInquiry.ConversationId);
            Assert.IsNotNull(loyaltyInquiry.SystemTime);
            Assert.IsNull(loyaltyInquiry.ErrorMessage);
        }
    }
}
