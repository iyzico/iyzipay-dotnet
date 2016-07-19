// <copyright file="PayoutCompletedTransactionList.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Collections.Generic;
    using Iyzipay.Request;

    /// <summary>
    /// Payout completed transaction list
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class PayoutCompletedTransactionList : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the payout completed transactions.
        /// </summary>
        /// <value>
        /// The payout completed transactions.
        /// </value>
        public List<PayoutCompletedTransaction> PayoutCompletedTransactions { get; set; }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static PayoutCompletedTransactionList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PayoutCompletedTransactionList>(options.BaseUrl + "/reporting/settlement/payoutcompleted", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
