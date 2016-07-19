// <copyright file="RetrieveSubMerchantRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    /// <summary>
    /// Retrieve sub-merchant request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class RetrieveSubMerchantRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the sub merchant external identifier.
        /// </summary>
        /// <value>
        /// The sub merchant external identifier.
        /// </value>
        public string SubMerchantExternalId { get; set; }

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
                .Append("subMerchantExternalId", this.SubMerchantExternalId)
                .GetRequestString();
        }
    }
}
