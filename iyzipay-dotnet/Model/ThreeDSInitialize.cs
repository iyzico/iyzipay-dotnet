// <copyright file="ThreedsInitialize.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;
    using Newtonsoft.Json;

    /// <summary>
    /// 3D-secure initialization
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class ThreedsInitialize : IyzipayResource
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
        public static ThreedsInitialize Create(CreatePaymentRequest request, Options options)
        {
            var response = RestHttpClient.Create().Post<ThreedsInitialize>(options.BaseUrl + "/payment/3dsecure/initialize", IyzipayResource.GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }

            return response;
        }
    }
}
