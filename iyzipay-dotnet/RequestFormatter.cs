// <copyright file="RequestFormatter.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    /// <summary>
    /// Request Formatter class
    /// </summary>
    public class RequestFormatter
    {
        /// <summary>
        /// Formats the price.
        /// </summary>
        /// <param name="price">The price.</param>
        /// <returns>The formatted price</returns>
        public static string FormatPrice(string price)
        {
            var invariantCulture = System.Globalization.CultureInfo.InvariantCulture;
            return decimal.Parse(price, invariantCulture).ToString("N1", invariantCulture);
        }
    }
}
