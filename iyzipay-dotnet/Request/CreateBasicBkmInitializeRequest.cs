// <copyright file="CreateBasicBkmInitializeRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;
    using System.Collections.Generic;
    using Iyzipay.Model;

    /// <summary>
    /// Create basic BKM initialize request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateBasicBkmInitializeRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        /// <value>
        /// The name of the connector.
        /// </value>
        public string ConnectorName { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the callback URL.
        /// </summary>
        /// <value>
        /// The callback URL.
        /// </value>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets the buyer email.
        /// </summary>
        /// <value>
        /// The buyer email.
        /// </value>
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Gets or sets the buyer identifier.
        /// </summary>
        /// <value>
        /// The buyer identifier.
        /// </value>
        public string BuyerId { get; set; }

        /// <summary>
        /// Gets or sets the buyer IP.
        /// </summary>
        /// <value>
        /// The buyer IP.
        /// </value>
        public string BuyerIp { get; set; }

        /// <summary>
        /// Gets or sets the position order identifier.
        /// </summary>
        /// <value>
        /// The position order identifier.
        /// </value>
        public string PosOrderId { get; set; }

        /// <summary>
        /// Gets or sets the installment details.
        /// </summary>
        /// <value>
        /// The installment details.
        /// </value>
        public List<BkmInstallment> InstallmentDetails { get; set; }

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
                .Append("connectorName", this.ConnectorName)
                .AppendPrice("price", this.Price)
                .Append("callbackUrl", this.CallbackUrl)
                .Append("buyerEmail", this.BuyerEmail)
                .Append("buyerId", this.BuyerId)
                .Append("buyerIp", this.BuyerIp)
                .Append("posOrderId", this.PosOrderId)
                .AppendList("installmentDetails", this.InstallmentDetails)
                .GetRequestString();
        }
    }
}
