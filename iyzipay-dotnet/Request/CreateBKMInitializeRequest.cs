// <copyright file="CreateBkmInitializeRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;
    using System.Collections.Generic;
    using Iyzipay.Model;

    /// <summary>
    /// Create BKM initialize request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateBkmInitializeRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the basket identifier.
        /// </summary>
        /// <value>
        /// The basket identifier.
        /// </value>
        public string BasketId { get; set; }

        /// <summary>
        /// Gets or sets the payment group.
        /// </summary>
        /// <value>
        /// The payment group.
        /// </value>
        public string PaymentGroup { get; set; }

        /// <summary>
        /// Gets or sets the payment source.
        /// </summary>
        /// <value>
        /// The payment source.
        /// </value>
        public string PaymentSource { get; set; }

        /// <summary>
        /// Gets or sets the buyer.
        /// </summary>
        /// <value>
        /// The buyer.
        /// </value>
        public Buyer Buyer { get; set; }

        /// <summary>
        /// Gets or sets the shipping address.
        /// </summary>
        /// <value>
        /// The shipping address.
        /// </value>
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets the billing address.
        /// </summary>
        /// <value>
        /// The billing address.
        /// </value>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the basket items.
        /// </summary>
        /// <value>
        /// The basket items.
        /// </value>
        public List<BasketItem> BasketItems { get; set; }

        /// <summary>
        /// Gets or sets the callback URL.
        /// </summary>
        /// <value>
        /// The callback URL.
        /// </value>
        public string CallbackUrl { get; set; }

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
                .AppendPrice("price", this.Price)
                .Append("basketId", this.BasketId)
                .Append("paymentGroup", this.PaymentGroup)
                .Append("buyer", this.Buyer)
                .Append("shippingAddress", this.ShippingAddress)
                .Append("billingAddress", this.BillingAddress)
                .AppendList("basketItems", this.BasketItems)
                .Append("callbackUrl", this.CallbackUrl)
                .Append("paymentSource", this.PaymentSource)
                .GetRequestString();
        }
    }
}
