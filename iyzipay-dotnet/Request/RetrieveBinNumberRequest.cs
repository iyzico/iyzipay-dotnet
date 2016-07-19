﻿// <copyright file="RetrieveBinNumberRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    /// <summary>
    /// Retrieve BIN number request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class RetrieveBinNumberRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the BIN number.
        /// </summary>
        /// <value>
        /// The BIN number.
        /// </value>
        public string BinNumber { get; set; }

        /// <summary>
        /// To PKI request string.
        /// </summary>
        /// <returns>
        /// The request as a PKI string
        /// </returns>
        public override string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("binNumber", this.BinNumber)
                .GetRequestString();
        }
    }
}
