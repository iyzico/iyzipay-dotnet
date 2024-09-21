using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class LoyaltyInquireTest : BaseTest
    {
        [Test]
        public async Task Should_Inquire_LoyaltyAsync()
        {
            LoyaltyInquiryRequest request = LoyaltyInquiryRequestBuilder.Create()
            .Currency("TRY")
            .Build();

            LoyaltyInquiry loyaltyInquiry = await LoyaltyInquiry.Create(request, _options);

            PrintResponse<LoyaltyInquiry>(loyaltyInquiry);

            Assert.AreEqual(Status.SUCCESS.ToString(), loyaltyInquiry.Status);
            Assert.AreEqual(Locale.TR.ToString(), loyaltyInquiry.Locale);
            Assert.AreEqual("123456789", loyaltyInquiry.ConversationId);
            Assert.IsNotNull(loyaltyInquiry.SystemTime);
            Assert.IsNotNull(loyaltyInquiry.Points);
            Assert.IsNotNull(loyaltyInquiry.Amount);
            Assert.IsNotNull(loyaltyInquiry.CardBank);
            Assert.IsNotNull(loyaltyInquiry.CardFamily);
            Assert.IsNotNull(loyaltyInquiry.Currency);
            Assert.IsNull(loyaltyInquiry.ErrorMessage);
        }
    }
}
