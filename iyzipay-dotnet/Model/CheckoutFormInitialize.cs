// <copyright file="CheckoutFormInitialize.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System;
    using Iyzipay.Request;

    /// <summary>
    /// Checkout form initialization
    /// </summary>
    /// <seealso cref="Iyzipay.Model.CheckoutFormInitializeResource" />
    public class CheckoutFormInitialize : CheckoutFormInitializeResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static CheckoutFormInitialize Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutFormInitialize>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/auth/ecom", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
