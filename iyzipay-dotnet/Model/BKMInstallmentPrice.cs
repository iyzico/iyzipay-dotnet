// <copyright file="BkmInstallmentPrice.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// BKM installment price
    /// </summary>
    /// <seealso cref="Iyzipay.IRequestStringConvertible" />
    public class BkmInstallmentPrice : IRequestStringConvertible
    {
        /// <summary>
        /// Gets or sets the installment number.
        /// </summary>
        /// <value>
        /// The installment number.
        /// </value>
        public int? InstallmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the total price.
        /// </summary>
        /// <value>
        /// The total price.
        /// </value>
        public string TotalPrice { get; set; }

        /// <summary>
        /// Converts to PKI request string.
        /// </summary>
        /// <returns>The request string</returns>
        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("installmentNumber", this.InstallmentNumber)
                .AppendPrice("totalPrice", this.TotalPrice)
                .GetRequestString();
        }
    }
}
