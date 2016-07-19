// <copyright file="RetrievePaymentRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Retrieve payment request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class RetrievePaymentRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the payment conversation identifier.
        /// </summary>
        /// <value>
        /// The payment conversation identifier.
        /// </value>
        public string PaymentConversationId { get; set; }

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
                .Append("paymentConversationId", this.PaymentConversationId)
                .GetRequestString();
        }
    }
}
