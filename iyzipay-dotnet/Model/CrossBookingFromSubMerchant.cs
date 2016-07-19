// <copyright file="CrossBookingFromSubMerchant.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Cross booking from sub-merchant
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class CrossBookingFromSubMerchant : IyzipayResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static CrossBookingFromSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CrossBookingFromSubMerchant>(options.BaseUrl + "/crossbooking/receive", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
