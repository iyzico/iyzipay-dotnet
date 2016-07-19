// <copyright file="BasicBkm.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Basic BKM
    /// </summary>
    /// <seealso cref="Iyzipay.Model.BasicPaymentResource" />
    public class BasicBkm : BasicPaymentResource
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the callback URL.
        /// </summary>
        /// <value>
        /// The callback URL.
        /// </value>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets the payment status.
        /// </summary>
        /// <value>
        /// The payment status.
        /// </value>
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BasicBkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicBkm>(options.BaseUrl + "/payment/bkm/auth/detail/basic", BasicBkm.GetHttpHeaders(request, options), request);
        }
    }
}
