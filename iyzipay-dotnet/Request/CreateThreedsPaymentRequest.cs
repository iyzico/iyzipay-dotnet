// <copyright file="CreateThreedsPaymentRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Create 3D-secure payment request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateThreedsPaymentRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the conversation data.
        /// </summary>
        /// <value>
        /// The conversation data.
        /// </value>
        public string ConversationData { get; set; }

        /// <summary>
        /// To PKI request string.
        /// </summary>
        /// <returns>
        /// The request as a PKI string
        /// </returns>
        public override string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentId", this.PaymentId)
                .Append("conversationData", this.ConversationData)
                .GetRequestString();
        }
    }
}
