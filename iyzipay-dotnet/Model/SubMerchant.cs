// <copyright file="SubMerchant.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// The sub-merchant
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class SubMerchant : IyzipayResource
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
        /// Gets or sets the swift code.
        /// </summary>
        /// <value>
        /// The swift code.
        /// </value>
        public string SwiftCode { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

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
        /// Gets or sets the sub merchant key.
        /// </summary>
        /// <value>
        /// The sub merchant key.
        /// </value>
        public string SubMerchantKey { get; set; }

        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static SubMerchant Create(CreateSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().Post<SubMerchant>(options.BaseUrl + "/onboarding/submerchant", IyzipayResource.GetHttpHeaders(request, options), request);
        }

        /// <summary>
        /// Updates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static SubMerchant Update(UpdateSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().Put<SubMerchant>(options.BaseUrl + "/onboarding/submerchant", IyzipayResource.GetHttpHeaders(request, options), request);
        }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static SubMerchant Retrieve(RetrieveSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().Post<SubMerchant>(options.BaseUrl + "/onboarding/submerchant/detail", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
