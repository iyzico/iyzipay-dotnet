// <copyright file="BasicPaymentPostAuth.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Basic payment post authentication
    /// </summary>
    /// <seealso cref="Iyzipay.Model.BasicPaymentResource" />
    public class BasicPaymentPostAuth : BasicPaymentResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BasicPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPaymentPostAuth>(options.BaseUrl + "/payment/postauth/basic", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
