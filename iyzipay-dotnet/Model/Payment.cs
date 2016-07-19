// <copyright file="Payment.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// The payment
    /// </summary>
    /// <seealso cref="Iyzipay.Model.PaymentResource" />
    public class Payment : PaymentResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static Payment Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Payment>(options.BaseUrl + "/payment/auth", IyzipayResource.GetHttpHeaders(request, options), request);
        }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static Payment Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Payment>(options.BaseUrl + "/payment/detail", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
