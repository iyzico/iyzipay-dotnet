using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ConnectCancelSample : Sample
    {
        [TestMethod]
        public void Should_Cancel_Payment()
        {
            CreateCancelRequest request = new CreateCancelRequest();
            request.Locale=Locale.TR.GetName();
            request.ConversationId="123456789";
            request.PaymentId="24";
            request.Ip="127.0.0.1";

            ConnectCancel connectCancel = ConnectCancel.Create(request, options);

            PrintResponse<ConnectCancel>(connectCancel);

            Assert.IsNotNull(connectCancel.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectCancel.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectCancel.Locale);
            Assert.AreEqual("123456789", connectCancel.ConversationId);
        }
    }
}
