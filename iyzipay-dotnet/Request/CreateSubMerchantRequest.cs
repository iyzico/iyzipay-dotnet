// <copyright file="CreateSubMerchantRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Create sub-merchant request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateSubMerchantRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the IBAN.
        /// </summary>
        /// <value>
        /// The IBAN.
        /// </value>
        public string Iban { get; set; }

        /// <summary>
        /// Gets or sets the tax office.
        /// </summary>
        /// <value>
        /// The tax office.
        /// </value>
        public string TaxOffice { get; set; }

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
        /// Gets or sets the sub merchant external identifier.
        /// </summary>
        /// <value>
        /// The sub merchant external identifier.
        /// </value>
        public string SubMerchantExternalId { get; set; }

        /// <summary>
        /// Gets or sets the identity number.
        /// </summary>
        /// <value>
        /// The identity number.
        /// </value>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Gets or sets the tax number.
        /// </summary>
        /// <value>
        /// The tax number.
        /// </value>
        public string TaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the sub merchant.
        /// </summary>
        /// <value>
        /// The type of the sub merchant.
        /// </value>
        public string SubMerchantType { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the swift code.
        /// </summary>
        /// <value>
        /// The swift code.
        /// </value>
        public string SwiftCode { get; set; }

        /// <summary>
        /// To PKI request string.
        /// </summary>
        /// <returns>
        /// The request as a PKI string
        /// </returns>
        public override string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("name", this.Name)
                .Append("email", this.Email)
                .Append("gsmNumber", this.GsmNumber)
                .Append("address", this.Address)
                .Append("iban", this.Iban)
                .Append("taxOffice", this.TaxOffice)
                .Append("contactName", this.ContactName)
                .Append("contactSurname", this.ContactSurname)
                .Append("legalCompanyTitle", this.LegalCompanyTitle)
                .Append("swiftCode", this.SwiftCode)
                .Append("currency", this.Currency)
                .Append("subMerchantExternalId", this.SubMerchantExternalId)
                .Append("identityNumber", this.IdentityNumber)
                .Append("taxNumber", this.TaxNumber)
                .Append("subMerchantType", this.SubMerchantType)
                .GetRequestString();
        }
    }
}
