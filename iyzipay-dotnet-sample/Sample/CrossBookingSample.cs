using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class CrossBookingSample : Sample
    {
        [TestMethod]
        public void Should_Send_Money_To_Sub_Merchant()
        {
            CreateCrossBookingRequest request = new CreateCrossBookingRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "subMerchantKey";
            request.Price = "1";
            request.Reason = "reason text";

            CrossBookingToSubMerchant crossBookingToSubMerchant = CrossBookingToSubMerchant.Create(request, options);

            PrintResponse<CrossBookingToSubMerchant>(crossBookingToSubMerchant);

            Assert.IsNotNull(crossBookingToSubMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), crossBookingToSubMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), crossBookingToSubMerchant.Locale);
            Assert.AreEqual("123456789", crossBookingToSubMerchant.ConversationId);
        }

        [TestMethod]
        public void Should_Receive_Money_From_Sub_Merchant()
        {
            CreateCrossBookingRequest request = new CreateCrossBookingRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.SubMerchantKey = "subMerchantKey";
            request.Price = "1";
            request.Reason = "reason text";

            CrossBookingFromSubMerchant crossBookingFromSubMerchant = CrossBookingFromSubMerchant.Create(request, options);

            PrintResponse<CrossBookingFromSubMerchant>(crossBookingFromSubMerchant);

            Assert.IsNotNull(crossBookingFromSubMerchant.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), crossBookingFromSubMerchant.Status);
            Assert.AreEqual(Locale.TR.GetName(), crossBookingFromSubMerchant.Locale);
            Assert.AreEqual("123456789", crossBookingFromSubMerchant.ConversationId);
        }
    }
}
