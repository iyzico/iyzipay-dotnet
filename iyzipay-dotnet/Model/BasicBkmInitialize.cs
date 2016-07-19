// <copyright file="BasicBkmInitialize.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Basic BKM initialization
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class BasicBkmInitialize : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the content of the HTML.
        /// </summary>
        /// <value>
        /// The content of the HTML.
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
        public static BasicBkmInitialize Create(CreateBasicBkmInitializeRequest request, Options options)
        {
            var response = RestHttpClient.Create().Post<BasicBkmInitialize>(options.BaseUrl + "/payment/bkm/initialize/basic", IyzipayResource.GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }

            return response;
        }
    }
}
