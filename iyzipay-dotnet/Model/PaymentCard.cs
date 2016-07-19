// <copyright file="PaymentCard.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// Payment card
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class PaymentCard : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the name of the card holder.
        /// </summary>
        /// <value>
        /// The name of the card holder.
        /// </value>
        public string CardHolderName { get; set; }

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
        /// Gets or sets the CVC code
        /// </summary>
        /// <value>
        /// The CVC
        /// </value>
        public string Cvc { get; set; }

        /// <summary>
        /// Gets or sets the register card.
        /// </summary>
        /// <value>
        /// The register card.
        /// </value>
        public int? RegisterCard { get; set; }

        /// <summary>
        /// Gets or sets the card alias.
        /// </summary>
        /// <value>
        /// The card alias.
        /// </value>
        public string CardAlias { get; set; }

        /// <summary>
        /// Gets or sets the card token.
        /// </summary>
        /// <value>
        /// The card token.
        /// </value>
        public string CardToken { get; set; }

        /// <summary>
        /// Gets or sets the card user key.
        /// </summary>
        /// <value>
        /// The card user key.
        /// </value>
        public string CardUserKey { get; set; }

        /// <summary>
        /// Converts entity to PKI request string.
        /// </summary>
        /// <returns>The request string</returns>
        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("cardHolderName", this.CardHolderName)
                .Append("cardNumber", this.CardNumber)
                .Append("expireYear", this.ExpireYear)
                .Append("expireMonth", this.ExpireMonth)
                .Append("cvc", this.Cvc)
                .Append("registerCard", this.RegisterCard)
                .Append("cardAlias", this.CardAlias)
                .Append("cardToken", this.CardToken)
                .Append("cardUserKey", this.CardUserKey)
                .GetRequestString();
        }
    }
}
