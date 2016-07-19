// <copyright file="BinNumber.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;
    using Newtonsoft.Json;

    /// <summary>
    /// BIN number
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class BinNumber : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the bin.
        /// </summary>
        /// <value>
        /// The bin.
        /// </value>
        [JsonProperty(PropertyName = "binNumber")]
        public string Bin { get; set; }

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
        /// Gets or sets the card family.
        /// </summary>
        /// <value>
        /// The card family.
        /// </value>
        public string CardFamily { get; set; }

        /// <summary>
        /// Gets or sets the name of the bank.
        /// </summary>
        /// <value>
        /// The name of the bank.
        /// </value>
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets the bank code.
        /// </summary>
        /// <value>
        /// The bank code.
        /// </value>
        public long BankCode { get; set; }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BinNumber Retrieve(RetrieveBinNumberRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BinNumber>(options.BaseUrl + "/payment/bin/check", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
