// <copyright file="IyzipayResource.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;

    /// <summary>
    /// Iyzipay resource
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
    public class IyzipayResource
    {
        /// <summary>
        /// The authorization
        /// </summary>
        private static readonly string Authorization = "Authorization";

        /// <summary>
        /// The random header name
        /// </summary>
        private static readonly string RandomHeaderName = "x-iyzi-rnd";

        /// <summary>
        /// The iyzi ws header name
        /// </summary>
        private static readonly string IyziWsHeaderName = "IYZWS ";

        /// <summary>
        /// The colon
        /// </summary>
        private static readonly string COLON = ":";

        /// <summary>
        /// Initializes a new instance of the <see cref="IyzipayResource"/> class.
        /// </summary>
        public IyzipayResource()
        {
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the error group.
        /// </summary>
        /// <value>
        /// The error group.
        /// </value>
        public string ErrorGroup { get; set; }

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        /// <value>
        /// The locale.
        /// </value>
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the system time.
        /// </summary>
        /// <value>
        /// The system time.
        /// </value>
        public long SystemTime { get; set; }

        /// <summary>
        /// Gets or sets the conversation identifier.
        /// </summary>
        /// <value>
        /// The conversation identifier.
        /// </value>
        public string ConversationId { get; set; }

        /// <summary>
        /// Gets the HTTP headers.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The HTTP headers</returns>
        protected static WebHeaderCollection GetHttpHeaders(BaseRequest request, Options options)
        {
            var randomString = DateTime.Now.ToString("ddMMyyyyhhmmssffff");
            var headers = new WebHeaderCollection();
            headers.Add("Accept", "application/json");
            headers.Add(RandomHeaderName, randomString);
            headers.Add(Authorization, PrepareAuthorizationString(request, randomString, options));
            return headers;
        }

        /// <summary>
        /// Prepares the authorization string.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="randomString">The random string.</param>
        /// <param name="options">The options.</param>
        /// <returns>The authorization string</returns>
        private static string PrepareAuthorizationString(BaseRequest request, string randomString, Options options)
        {
            var hash = HashGenerator.GenerateHash(options.ApiKey, options.SecretKey, randomString, request);
            return IyziWsHeaderName + options.ApiKey + COLON + hash;
        }
    }
}
