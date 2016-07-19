// <copyright file="CardInformation.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// Card information
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class CardInformation : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the card alias.
        /// </summary>
        /// <value>
        /// The card alias.
        /// </value>
        public string CardAlias { get; set; }

        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        /// <value>
        /// The card number.
        /// </value>
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the expire year.
        /// </summary>
        /// <value>
        /// The expire year.
        /// </value>
        public string ExpireYear { get; set; }

        /// <summary>
        /// Gets or sets the expire month.
        /// </summary>
        /// <value>
        /// The expire month.
        /// </value>
        public string ExpireMonth { get; set; }

        /// <summary>
        /// Gets or sets the name of the card holder.
        /// </summary>
        /// <value>
        /// The name of the card holder.
        /// </value>
        public string CardHolderName { get; set; }

        /// <summary>
        /// Converts entity to PKI request string
        /// </summary>
        /// <returns>The request string</returns>
        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("cardAlias", this.CardAlias)
                .Append("cardNumber", this.CardNumber)
                .Append("expireYear", this.ExpireYear)
                .Append("expireMonth", this.ExpireMonth)
                .Append("cardHolderName", this.CardHolderName)
                .GetRequestString();
        }
    }
}
