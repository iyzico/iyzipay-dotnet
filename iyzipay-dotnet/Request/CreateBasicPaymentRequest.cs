// <copyright file="CreateBasicPaymentRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;
    using Iyzipay.Model;

    /// <summary>
    /// Create basic payment request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateBasicPaymentRequest : BaseRequest
    {
        /// <summary>
        /// The single installment constant
        /// </summary>
        public const int SingleInstallment = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBasicPaymentRequest"/> class.
        /// </summary>
        public CreateBasicPaymentRequest()
        {
            this.Installment = SingleInstallment;
        }

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
        /// Gets or sets the payment card.
        /// </summary>
        /// <value>
        /// The payment card.
        /// </value>
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        /// <value>
        /// The name of the connector.
        /// </value>
        public string ConnectorName { get; set; }

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
                .AppendPrice("paidPrice", this.PaidPrice)
                .Append("installment", this.Installment)
                .Append("buyerEmail", this.BuyerEmail)
                .Append("buyerId", this.BuyerId)
                .Append("buyerIp", this.BuyerIp)
                .Append("posOrderId", this.PosOrderId)
                .Append("paymentCard", this.PaymentCard)
                .Append("currency", this.Currency)
                .Append("connectorName", this.ConnectorName)
                .Append("callbackUrl", this.CallbackUrl)
                .GetRequestString();
        }
    }
}
