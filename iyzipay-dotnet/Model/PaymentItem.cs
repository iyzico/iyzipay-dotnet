// <copyright file="PaymentItem.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Payment item
    /// </summary>
    public class PaymentItem
    {
        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>
        /// The item identifier.
        /// </value>
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the payment transaction identifier.
        /// </summary>
        /// <value>
        /// The payment transaction identifier.
        /// </value>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the transaction status.
        /// </summary>
        /// <value>
        /// The transaction status.
        /// </value>
        public int? TransactionStatus { get; set; }

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
        /// Gets or sets the blockage rate.
        /// </summary>
        /// <value>
        /// The blockage rate.
        /// </value>
        public string BlockageRate { get; set; }

        /// <summary>
        /// Gets or sets the blockage rate amount merchant.
        /// </summary>
        /// <value>
        /// The blockage rate amount merchant.
        /// </value>
        public string BlockageRateAmountMerchant { get; set; }

        /// <summary>
        /// Gets or sets the blockage rate amount sub merchant.
        /// </summary>
        /// <value>
        /// The blockage rate amount sub merchant.
        /// </value>
        public string BlockageRateAmountSubMerchant { get; set; }

        /// <summary>
        /// Gets or sets the blockage resolved date.
        /// </summary>
        /// <value>
        /// The blockage resolved date.
        /// </value>
        public string BlockageResolvedDate { get; set; }

        /// <summary>
        /// Gets or sets the sub merchant key.
        /// </summary>
        /// <value>
        /// The sub merchant key.
        /// </value>
        public string SubMerchantKey { get; set; }

        /// <summary>
        /// Gets or sets the sub merchant price.
        /// </summary>
        /// <value>
        /// The sub merchant price.
        /// </value>
        public string SubMerchantPrice { get; set; }

        /// <summary>
        /// Gets or sets the sub merchant payout rate.
        /// </summary>
        /// <value>
        /// The sub merchant payout rate.
        /// </value>
        public string SubMerchantPayoutRate { get; set; }

        /// <summary>
        /// Gets or sets the sub merchant payout amount.
        /// </summary>
        /// <value>
        /// The sub merchant payout amount.
        /// </value>
        public string SubMerchantPayoutAmount { get; set; }

        /// <summary>
        /// Gets or sets the merchant payout amount.
        /// </summary>
        /// <value>
        /// The merchant payout amount.
        /// </value>
        public string MerchantPayoutAmount { get; set; }

        /// <summary>
        /// Gets or sets the converted payout.
        /// </summary>
        /// <value>
        /// The converted payout.
        /// </value>
        public ConvertedPayout ConvertedPayout { get; set; }
    }
}
