// <copyright file="DigestHelper.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    using System;
    using System.Text;

    /// <summary>
    /// Digest helper
    /// </summary>
    public sealed class DigestHelper
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="DigestHelper"/> class from being created.
        /// </summary>
        private DigestHelper()
        {
        }

        /// <summary>
        /// Decodes the string.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>The decoded string</returns>
        public static string DecodeString(string content)
        {
            return (!string.IsNullOrEmpty(content)) ? Encoding.UTF8.GetString(Convert.FromBase64String(content)) : null;
        }
    }
}
