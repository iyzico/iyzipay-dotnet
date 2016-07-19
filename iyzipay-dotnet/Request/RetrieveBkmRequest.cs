// <copyright file="RetrieveBkmRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    /// <summary>
    /// Retrieve BKM request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class RetrieveBkmRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }

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
                .Append("token", this.Token)
                .GetRequestString();
        }
    }
}
