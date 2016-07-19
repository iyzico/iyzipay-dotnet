// <copyright file="PaymentPostAuth.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Payment post authorization
    /// </summary>
    /// <seealso cref="Iyzipay.Model.PaymentResource" />
    public class PaymentPostAuth : PaymentResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPostAuth>(options.BaseUrl + "/payment/postauth", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
