// <copyright file="ConvertedPayout.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Converted payout
    /// </summary>
    public class ConvertedPayout
    {
        /// <summary>
        /// Gets or sets the paid price.
        /// </summary>
        /// <value>
        /// The paid price.
        /// </value>
        public string PaidPrice { get; set; }

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
        /// Gets or sets the iyzi conversion rate.
        /// </summary>
        /// <value>
        /// The iyzi conversion rate.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        public string IyziConversionRate { get; set; }

        /// <summary>
        /// Gets or sets the iyzi conversion rate amount.
        /// </summary>
        /// <value>
        /// The iyzi conversion rate amount.
        /// </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        public string IyziConversionRateAmount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }
    }
}
