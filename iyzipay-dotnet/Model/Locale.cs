// <copyright file="Locale.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// The locale
    /// </summary>
    public sealed class Locale
    {
        /// <summary>
        /// The EN locale
        /// </summary>
        public static readonly Locale EN = new Locale(1, "en");

        /// <summary>
        /// The TR locale
        /// </summary>
        public static readonly Locale TR = new Locale(2, "tr");

        /// <summary>
        /// The name
        /// </summary>
        private readonly string name;

        /// <summary>
        /// The value
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Locale"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        private Locale(int value, string name)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>The name</returns>
        public string GetName()
        {
            return this.name;
        }
    }
}
