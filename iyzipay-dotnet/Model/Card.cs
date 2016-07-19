// <copyright file="Card.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// The card
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class Card : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        /// <value>
        /// The external identifier.
        /// </value>
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the card user key.
        /// </summary>
        /// <value>
        /// The card user key.
        /// </value>
        public string CardUserKey { get; set; }

        /// <summary>
        /// Gets or sets the card token.
        /// </summary>
        /// <value>
        /// The card token.
        /// </value>
        public string CardToken { get; set; }

        /// <summary>
        /// Gets or sets the card alias.
        /// </summary>
        /// <value>
        /// The card alias.
        /// </value>
        public string CardAlias { get; set; }

        /// <summary>
        /// Gets or sets the bin number.
        /// </summary>
        /// <value>
        /// The bin number.
        /// </value>
        public string BinNumber { get; set; }

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
        /// Gets or sets the card bank code.
        /// </summary>
        /// <value>
        /// The card bank code.
        /// </value>
        public long? CardBankCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the card bank.
        /// </summary>
        /// <value>
        /// The name of the card bank.
        /// </value>
        public string CardBankName { get; set; }

        /// <summary>
        /// Creates the specified card
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static Card Create(CreateCardRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Card>(options.BaseUrl + "/cardstorage/card", IyzipayResource.GetHttpHeaders(request, options), request);
        }

        /// <summary>
        /// Deletes the specified card
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static Card Delete(DeleteCardRequest request, Options options)
        {
            return RestHttpClient.Create().Delete<Card>(options.BaseUrl + "/cardstorage/card", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
