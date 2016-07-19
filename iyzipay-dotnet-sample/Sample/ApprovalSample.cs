// <copyright file="ApprovalSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Approval sample
    /// </summary>
    /// <seealso cref="IyzipaySample.Sample.Sample" />
    /// <summary>
    /// ApprovalSample
    /// </summary>
    [TestClass]
    public class ApprovalSample : Sample
    {
        /// <summary>
        /// Should approve payment item.
        /// </summary>
        [TestMethod]
        public void ShouldApprovePaymentItem()
        {
            var request = new CreateApprovalRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "2";

            var approval = Approval.Create(request, Options);

            this.PrintResponse<Approval>(approval);

            Assert.IsNotNull(approval.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), approval.Status);
            Assert.AreEqual(Locale.TR.GetName(), approval.Locale);
            Assert.AreEqual("123456789", approval.ConversationId);
            Assert.AreEqual("2", approval.PaymentTransactionId);
        }

        /// <summary>
        /// Should disapprove payment item.
        /// </summary>
        [TestMethod]
        public void ShouldDisapprovePaymentItem()
        {
            var request = new CreateApprovalRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentTransactionId = "2";

            var disapproval = Disapproval.Create(request, Options);

            this.PrintResponse<Disapproval>(disapproval);

            Assert.IsNotNull(disapproval.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), disapproval.Status);
            Assert.AreEqual(Locale.TR.GetName(), disapproval.Locale);
            Assert.AreEqual("123456789", disapproval.ConversationId);
            Assert.AreEqual("2", disapproval.PaymentTransactionId);
        }
    }
}
