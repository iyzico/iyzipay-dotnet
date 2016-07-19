// <copyright file="BkmInitialize.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// BKM initialize
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class BkmInitialize : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the HTML content
        /// </summary>
        /// <value>
        /// The HTML content
        /// </value>
        public string HtmlContent { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }

        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BkmInitialize Create(CreateBkmInitializeRequest request, Options options)
        {
            var response = RestHttpClient.Create().Post<BkmInitialize>(options.BaseUrl + "/payment/bkm/initialize", IyzipayResource.GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }

            return response;
        }
    }
}
