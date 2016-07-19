// <copyright file="CreateCrossBookingRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Create cross booking request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateCrossBookingRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the sub merchant key.
        /// </summary>
        /// <value>
        /// The sub merchant key.
        /// </value>
        public string SubMerchantKey { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public string Reason { get; set; }

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
                .Append("subMerchantKey", this.SubMerchantKey)
                .AppendPrice("price", this.Price)
                .Append("reason", this.Reason)
                .Append("currency", this.Currency)
                .GetRequestString();
        }
    }
}
