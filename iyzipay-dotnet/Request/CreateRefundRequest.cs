// <copyright file="CreateRefundRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Create refund request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateRefundRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the payment transaction identifier.
        /// </summary>
        /// <value>
        /// The payment transaction identifier.
        /// </value>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the IP.
        /// </summary>
        /// <value>
        /// The IP.
        /// </value>
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

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
                .Append("paymentTransactionId", this.PaymentTransactionId)
                .AppendPrice("price", this.Price)
                .Append("ip", this.Ip)
                .Append("currency", this.Currency)
                .GetRequestString();
        }
    }
}
