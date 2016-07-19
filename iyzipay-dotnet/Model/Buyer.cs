// <copyright file="Buyer.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System;

    /// <summary>
    /// The buyer
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class Buyer : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the identity number.
        /// </summary>
        /// <value>
        /// The identity number.
        /// </value>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the GSM number.
        /// </summary>
        /// <value>
        /// The GSM number.
        /// </value>
        public string GsmNumber { get; set; }

        /// <summary>
        /// Gets or sets the registration date.
        /// </summary>
        /// <value>
        /// The registration date.
        /// </value>
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Gets or sets the last login date.
        /// </summary>
        /// <value>
        /// The last login date.
        /// </value>
        public string LastLoginDate { get; set; }

        /// <summary>
        /// Gets or sets the registration address.
        /// </summary>
        /// <value>
        /// The registration address.
        /// </value>
        public string RegistrationAddress { get; set; }

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
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the IP.
        /// </summary>
        /// <value>
        /// The IP.
        /// </value>
        public string Ip { get; set; }

        /// <summary>
        /// Converts entity to PKI request string.
        /// </summary>
        /// <returns>The request string</returns>
        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("id", this.Id)
                .Append("name", this.Name)
                .Append("surname", this.Surname)
                .Append("identityNumber", this.IdentityNumber)
                .Append("email", this.Email)
                .Append("gsmNumber", this.GsmNumber)
                .Append("registrationDate", this.RegistrationDate)
                .Append("lastLoginDate", this.LastLoginDate)
                .Append("registrationAddress", this.RegistrationAddress)
                .Append("city", this.City)
                .Append("country", this.Country)
                .Append("zipCode", this.ZipCode)
                .Append("ip", this.Ip)
                .GetRequestString();
        }
    }
}
