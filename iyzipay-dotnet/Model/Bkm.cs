// <copyright file="Bkm.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Payment resource
    /// </summary>
    /// <seealso cref="Iyzipay.Model.PaymentResource" />
    public class Bkm : PaymentResource
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
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static Bkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Bkm>(options.BaseUrl + "/payment/bkm/auth/detail", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
