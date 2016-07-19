// <copyright file="HashGenerator.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Hash generator
    /// </summary>
    public sealed class HashGenerator
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="HashGenerator"/> class from being created.
        /// </summary>
        private HashGenerator()
        {
        }

        /// <summary>
        /// Generates the hash.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="randomString">The random string.</param>
        /// <param name="request">The request.</param>
        /// <returns>The generated hash</returns>
        public static string GenerateHash(string apiKey, string secretKey, string randomString, BaseRequest request)
        {
            var algorithm = new SHA1Managed();
            var hashStr = apiKey + randomString + secretKey + request.ToPkiRequestString();
            var computeHash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashStr));
            return Convert.ToBase64String(computeHash);
        }
    }
}
