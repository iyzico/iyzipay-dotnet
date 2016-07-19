// <copyright file="BkmInstallment.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// BKM installment
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class BkmInstallment : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public long? BankId { get; set; }

        /// <summary>
        /// Gets or sets the installment prices.
        /// </summary>
        /// <value>
        /// The installment prices.
        /// </value>
        public List<BkmInstallmentPrice> InstallmentPrices { get; set; }

        /// <summary>
        /// Converts request to PKI request string
        /// </summary>
        /// <returns>The request string</returns>
        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("bankId", this.BankId)
                .AppendList("installmentPrices", this.InstallmentPrices)
                .GetRequestString();
        }
    }
}
