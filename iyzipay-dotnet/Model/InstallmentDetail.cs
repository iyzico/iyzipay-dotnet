// <copyright file="InstallmentDetail.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Installment details
    /// </summary>
    public class InstallmentDetail
    {
        /// <summary>
        /// Gets or sets the bin number.
        /// </summary>
        /// <value>
        /// The bin number.
        /// </value>
        public string BinNumber { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

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
        /// Gets or sets the name of the card family.
        /// </summary>
        /// <value>
        /// The name of the card family.
        /// </value>
        public string CardFamilyName { get; set; }

        /// <summary>
        /// Gets or sets the force3 ds.
        /// </summary>
        /// <value>
        /// The force3 ds.
        /// </value>
        public int? Force3Ds { get; set; }

        /// <summary>
        /// Gets or sets the bank code.
        /// </summary>
        /// <value>
        /// The bank code.
        /// </value>
        public long? BankCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the bank.
        /// </summary>
        /// <value>
        /// The name of the bank.
        /// </value>
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets the installment prices.
        /// </summary>
        /// <value>
        /// The installment prices.
        /// </value>
        public List<InstallmentPrice> InstallmentPrices { get; set; }
    }
}
