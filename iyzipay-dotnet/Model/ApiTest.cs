// <copyright file="ApiTest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// API Test
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class ApiTest : IyzipayResource
    {
        /// <summary>
        /// Retrieves the resource
        /// </summary>
        /// <param name="options">The options</param>
        /// <returns>The response</returns>
        public static IyzipayResource Retrieve(Options options)
        {
            return RestHttpClient.Create().Get<IyzipayResource>(options.BaseUrl + "/payment/test");
        }
    }
}
