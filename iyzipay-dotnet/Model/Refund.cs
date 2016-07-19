// <copyright file="Refund.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// The refund
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class Refund : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the payment transaction identifier.
        /// </summary>
        /// <value>
        /// The payment transaction identifier.
        /// </value>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        /// <value>
        /// The name of the connector.
        /// </value>
        public string ConnectorName { get; set; }

        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static Refund Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Refund>(options.BaseUrl + "/payment/refund", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
