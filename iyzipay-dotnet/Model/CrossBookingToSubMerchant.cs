// <copyright file="CrossBookingToSubMerchant.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Cross booking to sub-merchant
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class CrossBookingToSubMerchant : IyzipayResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static CrossBookingToSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CrossBookingToSubMerchant>(options.BaseUrl + "/crossbooking/send", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
