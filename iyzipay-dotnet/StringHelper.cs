// <copyright file="StringHelper.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    using System;

    /// <summary>
    /// String helper
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Reverses the specified string
        /// </summary>
        /// <param name="s">The string to reverse</param>
        /// <returns>The reversed string</returns>
        public static string Reverse(this string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
