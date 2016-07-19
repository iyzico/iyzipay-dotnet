// <copyright file="CheckoutFormInitializeResource.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// Checkout form initialization resource
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class CheckoutFormInitializeResource : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the content of the checkout form.
        /// </summary>
        /// <value>
        /// The content of the checkout form.
        /// </value>
        public string CheckoutFormContent { get; set; }

        /// <summary>
        /// Gets or sets the token expire time.
        /// </summary>
        /// <value>
        /// The token expire time.
        /// </value>
        public long? TokenExpireTime { get; set; }

        /// <summary>
        /// Gets or sets the payment page URL.
        /// </summary>
        /// <value>
        /// The payment page URL.
        /// </value>
        public string PaymentPageUrl { get; set; }
    }
}
