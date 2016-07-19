// <copyright file="CancelSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Cancel sample
    /// </summary>
    [TestClass]
    public class CancelSample : Sample
    {
        /// <summary>
        /// Should cancel payment.
        /// </summary>
        [TestMethod]
        public void ShouldCancelPayment()
        {
            var request = new CreateCancelRequest();
            request.ConversationId = "123456789";
            request.Locale = Locale.TR.GetName();
            request.PaymentId = "1";
            request.Ip = "85.34.78.112";

            var cancel = Cancel.Create(request, Options);

            this.PrintResponse<Cancel>(cancel);

            Assert.IsNotNull(cancel.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(Locale.TR.GetName(), cancel.Locale);
            Assert.AreEqual("123456789", cancel.ConversationId);
            Assert.AreEqual("1", cancel.PaymentId);
        }
    }
}
