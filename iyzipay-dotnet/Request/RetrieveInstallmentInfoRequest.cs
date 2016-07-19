// <copyright file="RetrieveInstallmentInfoRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    using System;

    /// <summary>
    /// Retrieve installment info request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class RetrieveInstallmentInfoRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the bin number.
        /// </summary>
        /// <value>
        /// The bin number.
        /// </value>
        public string BinNumber { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public string Price { get; set; }

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
                .AppendPrice("price", this.Price)
                .GetRequestString();
        }
    }
}
