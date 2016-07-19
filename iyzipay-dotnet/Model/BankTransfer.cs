// <copyright file="BankTransfer.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Bank transfer
    /// </summary>
    public class BankTransfer
    {
        /// <summary>
        /// Gets or sets the sub merchant key.
        /// </summary>
        /// <value>
        /// The sub merchant key.
        /// </value>
        public string SubMerchantKey { get; set; }

        /// <summary>
        /// Gets or sets the IBAN
        /// </summary>
        /// <value>
        /// The IBAN
        /// </value>
        public string Iban { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact.
        /// </summary>
        /// <value>
        /// The name of the contact.
        /// </value>
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the contact surname.
        /// </summary>
        /// <value>
        /// The contact surname.
        /// </value>
        public string ContactSurname { get; set; }

        /// <summary>
        /// Gets or sets the legal company title.
        /// </summary>
        /// <value>
        /// The legal company title.
        /// </value>
        public string LegalCompanyTitle { get; set; }

        /// <summary>
        /// Gets or sets the type of the marketplace sub merchant.
        /// </summary>
        /// <value>
        /// The type of the marketplace sub merchant.
        /// </value>
        [JsonProperty(PropertyName = "marketplaceSubmerchantType")]
        public string MarketplaceSubMerchantType { get; set; }
    }
}
