// <copyright file="BasicThreedsPayment.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Basic 3D-secure payment
    /// </summary>
    /// <seealso cref="Iyzipay.Model.BasicPaymentResource" />
    public class BasicThreedsPayment : BasicPaymentResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BasicThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth/basic", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
