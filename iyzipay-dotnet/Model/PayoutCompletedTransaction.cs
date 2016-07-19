// <copyright file="PayoutCompletedTransaction.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// Payout completed transaction
    /// </summary>
    public class PayoutCompletedTransaction
    {
        /// <summary>
        /// Gets or sets the payment transaction identifier.
        /// </summary>
        /// <value>
        /// The payment transaction identifier.
        /// </value>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the payout amount.
        /// </summary>
        /// <value>
        /// The payout amount.
        /// </value>
        public string PayoutAmount { get; set; }

        /// <summary>
        /// Gets or sets the type of the payout.
        /// </summary>
        /// <value>
        /// The type of the payout.
        /// </value>
        public string PayoutType { get; set; }

        /// <summary>
        /// Gets or sets the sub merchant key.
        /// </summary>
        /// <value>
        /// The sub merchant key.
        /// </value>
        public string SubMerchantKey { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }
    }
}
