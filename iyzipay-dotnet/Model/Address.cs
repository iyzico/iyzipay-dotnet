// <copyright file="Address.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Address entity
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class Address : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty(PropertyName = "Address")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact.
        /// </summary>
        /// <value>
        /// The name of the contact.
        /// </value>
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Converts the entity to PKI request string
        /// </summary>
        /// <returns>The request as a PKI request string</returns>
        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("address", this.Description)
                .Append("zipCode", this.ZipCode)
                .Append("contactName", this.ContactName)
                .Append("city", this.City)
                .Append("country", this.Country)
                .GetRequestString();
        }
    }
}
