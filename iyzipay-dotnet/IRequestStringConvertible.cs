// <copyright file="IRequestStringConvertible.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    /// <summary>
    /// Request string convertible interface
    /// </summary>
    public interface IRequestStringConvertible
    {
        /// <summary>
        /// Convert to PKI request string
        /// </summary>
        /// <returns>The PKI request string</returns>
        string ToPkiRequestString();
    }
}
