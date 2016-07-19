// <copyright file="Status.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    /// <summary>
    /// The status
    /// </summary>
    public sealed class Status
    {
        /// <summary>
        /// The success
        /// </summary>
        public static readonly Status SUCCESS = new Status(1, "success");

        /// <summary>
        /// The failure
        /// </summary>
        public static readonly Status FAILURE = new Status(2, "failure");

        /// <summary>
        /// The name
        /// </summary>
        private readonly string name;

        /// <summary>
        /// The value
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Status"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        private Status(int value, string name)
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
