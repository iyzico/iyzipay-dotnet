// <copyright file="CreatePaymentRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;
    using System.Collections.Generic;
    using Iyzipay.Model;

    /// <summary>
    /// create payment request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreatePaymentRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the paid price.
        /// </summary>
        /// <value>
        /// The paid price.
        /// </value>
        public string PaidPrice { get; set; }

        /// <summary>
        /// Gets or sets the installment.
        /// </summary>
        /// <value>
        /// The installment.
        /// </value>
        public int? Installment { get; set; }

        /// <summary>
        /// Gets or sets the payment channel.
        /// </summary>
        /// <value>
        /// The payment channel.
        /// </value>
        public string PaymentChannel { get; set; }

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
        /// Gets or sets the payment card.
        /// </summary>
        /// <value>
        /// The payment card.
        /// </value>
        public PaymentCard PaymentCard { get; set; }

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
        /// Gets or sets the payment source.
        /// </summary>
        /// <value>
        /// The payment source.
        /// </value>
        public string PaymentSource { get; set; }

        /// <summary>
        /// Gets or sets the callback URL.
        /// </summary>
        /// <value>
        /// The callback URL.
        /// </value>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets the position order identifier.
        /// </summary>
        /// <value>
        /// The position order identifier.
        /// </value>
        public string PosOrderId { get; set; }

        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        /// <value>
        /// The name of the connector.
        /// </value>
        public string ConnectorName { get; set; }

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
                .AppendPrice("price", this.Price)
                .AppendPrice("paidPrice", this.PaidPrice)
                .Append("installment", this.Installment)
                .Append("paymentChannel", this.PaymentChannel)
                .Append("basketId", this.BasketId)
                .Append("paymentGroup", this.PaymentGroup)
                .Append("paymentCard", this.PaymentCard)
                .Append("buyer", this.Buyer)
                .Append("shippingAddress", this.ShippingAddress)
                .Append("billingAddress", this.BillingAddress)
                .AppendList("basketItems", this.BasketItems)
                .Append("paymentSource", this.PaymentSource)
                .Append("currency", this.Currency)
                .Append("posOrderId", this.PosOrderId)
                .Append("connectorName", this.ConnectorName)
                .Append("callbackUrl", this.CallbackUrl)
                .GetRequestString();
        }
    }
}
