// <copyright file="BasicThreedsInitializePreAuth.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;
    using Newtonsoft.Json;

    /// <summary>
    /// Basic 3D-secure initialization pre authorization
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class BasicThreedsInitializePreAuth : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the content of the HTML.
        /// </summary>
        /// <value>
        /// The content of the HTML.
        /// </value>
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BasicThreedsInitializePreAuth Create(CreateBasicPaymentRequest request, Options options)
        {
            var response = RestHttpClient.Create().Post<BasicThreedsInitializePreAuth>(options.BaseUrl + "/payment/3dsecure/initialize/preauth/basic", IyzipayResource.GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }

            return response;
        }
    }
}
