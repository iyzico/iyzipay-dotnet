// <copyright file="CreatePaymentPostAuthRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Create payment post authentication request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreatePaymentPostAuthRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the paid price.
        /// </summary>
        /// <value>
        /// The paid price.
        /// </value>
        public string PaidPrice { get; set; }

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
                .Append("paymentId", this.PaymentId)
                .Append("ip", this.Ip)
                .AppendPrice("paidPrice", this.PaidPrice)
                .Append("currency", this.Currency)
                .GetRequestString();
        }
    }
}
