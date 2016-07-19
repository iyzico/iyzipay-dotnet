// <copyright file="CreateCancelRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Create cancel request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateCancelRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the IP.
        /// </summary>
        /// <value>
        /// The IP.
        /// </value>
        public string Ip { get; set; }

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
                .Append("ip", this.Ip)
                .GetRequestString();
        }
    }
}
