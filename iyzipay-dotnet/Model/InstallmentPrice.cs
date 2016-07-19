// <copyright file="InstallmentPrice.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Installment price
    /// </summary>
    public class InstallmentPrice
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [JsonProperty(PropertyName = "InstallmentPrice")]
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the total price.
        /// </summary>
        /// <value>
        /// The total price.
        /// </value>
        public string TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets the installment number.
        /// </summary>
        /// <value>
        /// The installment number.
        /// </value>
        public int? InstallmentNumber { get; set; }
    }
}
