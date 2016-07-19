// <copyright file="CardList.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Collections.Generic;
    using Iyzipay.Request;
    using Newtonsoft.Json;

    /// <summary>
    /// Card list
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class CardList : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the card user key.
        /// </summary>
        /// <value>
        /// The card user key.
        /// </value>
        [JsonProperty(PropertyName = "cardUserKey")]
        public string CardUserKey { get; set; }

        /// <summary>
        /// Gets or sets the card details.
        /// </summary>
        /// <value>
        /// The card details.
        /// </value>
        [JsonProperty(PropertyName = "cardDetails")]
        public List<Card> CardDetails { get; set; }

        /// <summary>
        /// Retrieves the card list
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static CardList Retrieve(RetrieveCardListRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CardList>(options.BaseUrl + "/cardstorage/cards", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
