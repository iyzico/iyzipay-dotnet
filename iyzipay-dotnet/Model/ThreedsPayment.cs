// <copyright file="ThreedsPayment.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// 3D-secure payment
    /// </summary>
    /// <seealso cref="Iyzipay.Model.PaymentResource" />
    public class ThreedsPayment : PaymentResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static ThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth", IyzipayResource.GetHttpHeaders(request, options), request);
        }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static ThreedsPayment Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ThreedsPayment>(options.BaseUrl + "/payment/detail", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
