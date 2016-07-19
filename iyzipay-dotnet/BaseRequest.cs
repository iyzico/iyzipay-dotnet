// <copyright file="BaseRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    /// <summary>
    /// Base request
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class BaseRequest : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        /// <value>
        /// The locale.
        /// </value>
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the conversation identifier.
        /// </summary>
        /// <value>
        /// The conversation identifier.
        /// </value>
        public string ConversationId { get; set; }

        /// <summary>
        /// To PKI request string.
        /// </summary>
        /// <returns>The request as a PKI string</returns>
        public virtual string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("locale", this.Locale)
                .Append("conversationId", this.ConversationId)
                .GetRequestString();
        }
    }
}
