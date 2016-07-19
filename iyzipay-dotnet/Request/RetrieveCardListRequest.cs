// <copyright file="RetrieveCardListRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    /// <summary>
    /// Retrieve card list request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class RetrieveCardListRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the card user key.
        /// </summary>
        /// <value>
        /// The card user key.
        /// </value>
        public string CardUserKey { get; set; }

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
                .Append("cardUserKey", this.CardUserKey)
                .GetRequestString();
        }
    }
}
