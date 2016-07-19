// <copyright file="Currency.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// The currency
    /// </summary>
    public sealed class Currency
    {
        /// <summary>
        /// The TRY
        /// </summary>
        public static readonly Currency TRY = new Currency(1, "TRY");

        /// <summary>
        /// The EUR
        /// </summary>
        public static readonly Currency EUR = new Currency(2, "EUR");

        /// <summary>
        /// The USD
        /// </summary>
        public static readonly Currency USD = new Currency(3, "USD");

        /// <summary>
        /// The GBP
        /// </summary>
        public static readonly Currency GBP = new Currency(4, "GBP");

        /// <summary>
        /// The name
        /// </summary>
        private readonly string name;

        /// <summary>
        /// The value
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        private Currency(int value, string name)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.name;
        }
    }
}
