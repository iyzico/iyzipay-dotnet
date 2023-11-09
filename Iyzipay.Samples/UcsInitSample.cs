using Iyzipay.Model;
using Iyzipay.Model.V2;
using Iyzipay.Request;
using NUnit.Framework;
using System;

namespace Iyzipay.Samples
{
    public class UcsInitSample : Sample
    {
        [Test]
        public void Should_Ucs_Initialize()
        {
            InitUcsRequest request = new InitUcsRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Email = "email@email.com";
            request.GsmNumber = "+905350000000";

            UcsInit ucsInitCreate = UcsInit.Create(request, options);

            PrintResponse<UcsInit>(ucsInitCreate);

            Assert.AreEqual(Status.SUCCESS.ToString(), ucsInitCreate.Status);
            Assert.AreEqual(Locale.TR.ToString(), ucsInitCreate.Locale);
            Assert.IsNotNull(ucsInitCreate.SystemTime);
            Assert.AreEqual("123456789", ucsInitCreate.ConversationId);
            Assert.IsNotNull(ucsInitCreate.UcsToken);
            Assert.IsNotNull(ucsInitCreate.BuyerProtectedConsumer);
            Assert.IsNotNull(ucsInitCreate.BuyerProtectedMerchant);
            Assert.IsNotNull(ucsInitCreate.GsmNumber);
            Assert.IsNotNull(ucsInitCreate.MaskedGsmNumber);
            Assert.IsNotNull(ucsInitCreate.MerchantName);
            Assert.IsNotNull(ucsInitCreate.Script);
            Assert.IsNotNull(ucsInitCreate.ScriptType);
        }
    }
}