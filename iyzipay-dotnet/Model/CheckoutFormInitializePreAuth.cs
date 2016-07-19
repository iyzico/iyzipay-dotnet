// <copyright file="CheckoutFormInitializePreAuth.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Checkout form initialization pre authorization
    /// </summary>
    /// <seealso cref="Iyzipay.Model.CheckoutFormInitializeResource" />
    public class CheckoutFormInitializePreAuth : CheckoutFormInitializeResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static CheckoutFormInitializePreAuth Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutFormInitializePreAuth>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/preauth/ecom", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
