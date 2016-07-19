// <copyright file="Approval.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Approval resource
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class Approval : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the payment transaction identifier.
        /// </summary>
        /// <value>
        /// The payment transaction identifier.
        /// </value>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// Creates the specified request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="options">The options</param>
        /// <returns>The response</returns>
        public static Approval Create(CreateApprovalRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Approval>(options.BaseUrl + "/payment/iyzipos/item/approve", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
