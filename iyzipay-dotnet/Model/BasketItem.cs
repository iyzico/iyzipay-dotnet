// <copyright file="BasketItem.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System;

    /// <summary>
    /// Basket item
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class BasketItem : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category1.
        /// </summary>
        /// <value>
        /// The category1.
        /// </value>
        public string Category1 { get; set; }

        /// <summary>
        /// Gets or sets the category2.
        /// </summary>
        /// <value>
        /// The category2.
        /// </value>
        public string Category2 { get; set; }

        /// <summary>
        /// Gets or sets the type of the item.
        /// </summary>
        /// <value>
        /// The type of the item.
        /// </value>
        public string ItemType { get; set; }

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
        /// Converts the entity to PKI request string.
        /// </summary>
        /// <returns>The entity as a PKI string</returns>
        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("id", this.Id)
                .AppendPrice("price", this.Price)
                .Append("name", this.Name)
                .Append("category1", this.Category1)
                .Append("category2", this.Category2)
                .Append("itemType", this.ItemType)
                .Append("subMerchantKey", this.SubMerchantKey)
                .AppendPrice("subMerchantPrice", this.SubMerchantPrice)
                .GetRequestString();
        }
    }
}
