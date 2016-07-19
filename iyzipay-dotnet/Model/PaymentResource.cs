// <copyright file="PaymentResource.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Newtonsoft.Json;

    /// <summary>
    /// Payment resource
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class PaymentResource : IyzipayResource
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
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the payment status.
        /// </summary>
        /// <value>
        /// The payment status.
        /// </value>
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Gets or sets the fraud status.
        /// </summary>
        /// <value>
        /// The fraud status.
        /// </value>
        public int? FraudStatus { get; set; }

        /// <summary>
        /// Gets or sets the merchant commission rate.
        /// </summary>
        /// <value>
        /// The merchant commission rate.
        /// </value>
        public string MerchantCommissionRate { get; set; }

        /// <summary>
        /// Gets or sets the merchant commission rate amount.
        /// </summary>
        /// <value>
        /// The merchant commission rate amount.
        /// </value>
        public string MerchantCommissionRateAmount { get; set; }

        /// <summary>
        /// Gets or sets the iyzi commission rate amount.
        /// </summary>
        /// <value>
        /// The iyzi commission rate amount.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        public string IyziCommissionRateAmount { get; set; }

        /// <summary>
        /// Gets or sets the iyzi commission fee.
        /// </summary>
        /// <value>
        /// The iyzi commission fee.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        public string IyziCommissionFee { get; set; }

        /// <summary>
        /// Gets or sets the type of the card.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public string CardType { get; set; }

        /// <summary>
        /// Gets or sets the card association.
        /// </summary>
        /// <value>
        /// The card association.
        /// </value>
        public string CardAssociation { get; set; }

        /// <summary>
        /// Gets or sets the card family.
        /// </summary>
        /// <value>
        /// The card family.
        /// </value>
        public string CardFamily { get; set; }

        /// <summary>
        /// Gets or sets the card token.
        /// </summary>
        /// <value>
        /// The card token.
        /// </value>
        public string CardToken { get; set; }

        /// <summary>
        /// Gets or sets the card user key.
        /// </summary>
        /// <value>
        /// The card user key.
        /// </value>
        public string CardUserKey { get; set; }

        /// <summary>
        /// Gets or sets the bin number.
        /// </summary>
        /// <value>
        /// The bin number.
        /// </value>
        public string BinNumber { get; set; }

        /// <summary>
        /// Gets or sets the basket identifier.
        /// </summary>
        /// <value>
        /// The basket identifier.
        /// </value>
        public string BasketId { get; set; }

        /// <summary>
        /// Gets or sets the payment items.
        /// </summary>
        /// <value>
        /// The payment items.
        /// </value>
        [JsonProperty(PropertyName = "itemTransactions")]
        public List<PaymentItem> PaymentItems { get; set; }

        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        /// <value>
        /// The name of the connector.
        /// </value>
        public string ConnectorName { get; set; }
    }
}
