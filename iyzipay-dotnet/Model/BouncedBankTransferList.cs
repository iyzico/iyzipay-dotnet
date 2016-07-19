// <copyright file="BouncedBankTransferList.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Collections.Generic;
    using Iyzipay.Request;
    using Newtonsoft.Json;

    /// <summary>
    /// Bounced bank transfer list
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class BouncedBankTransferList : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the bank transfers.
        /// </summary>
        /// <value>
        /// The bank transfers.
        /// </value>
        [JsonProperty(PropertyName = "bouncedRows")]
        public List<BankTransfer> BankTransfers { get; set; }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BouncedBankTransferList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BouncedBankTransferList>(options.BaseUrl + "/reporting/settlement/bounced", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
