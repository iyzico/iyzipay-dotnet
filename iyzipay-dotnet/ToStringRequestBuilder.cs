// <copyright file="ToStringRequestBuilder.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Request builder
    /// </summary>
    public class ToStringRequestBuilder
    {
        /// <summary>
        /// The _request string
        /// </summary>
        private string requestString;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToStringRequestBuilder"/> class.
        /// </summary>
        /// <param name="requestString">The request string.</param>
        private ToStringRequestBuilder(string requestString)
        {
            this.requestString = requestString;
        }

        /// <summary>
        /// News the instance.
        /// </summary>
        /// <returns>The new instance</returns>
        public static ToStringRequestBuilder NewInstance()
        {
            return new ToStringRequestBuilder(string.Empty);
        }

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="requestString">The request string</param>
        /// <returns>A new instance</returns>
        public static ToStringRequestBuilder NewInstance(string requestString)
        {
            return new ToStringRequestBuilder(requestString);
        }

        /// <summary>
        /// Appends the super.
        /// </summary>
        /// <param name="superRequestString">The super request string.</param>
        /// <returns>The instance</returns>
        public ToStringRequestBuilder AppendSuper(string superRequestString)
        {
            if (superRequestString != null)
            {
                superRequestString = superRequestString.Substring(1);
                superRequestString = superRequestString.Substring(0, superRequestString.Length - 1);

                if (superRequestString.Length > 0)
                {
                    this.requestString = this.requestString + superRequestString + ",";
                }
            }

            return this;
        }

        /// <summary>
        /// Appends the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>The instance</returns>
        public ToStringRequestBuilder Append(string key, object value = null)
        {
            if (value != null)
            {
                if (value is IRequestStringConvertible)
                {
                    this.AppendKeyValue(key, ((IRequestStringConvertible)value).ToPkiRequestString());
                }
                else
                {
                    this.AppendKeyValue(key, value.ToString());
                }
            }

            return this;
        }

        /// <summary>
        /// Appends the price.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>The instance</returns>
        public ToStringRequestBuilder AppendPrice(string key, string value)
        {
            if (value != null)
            {
                this.AppendKeyValue(key, RequestFormatter.FormatPrice(value));
            }

            return this;
        }

        /// <summary>
        /// Appends the list.
        /// </summary>
        /// <typeparam name="T">Type of the list</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="list">The list.</param>
        /// <returns>The instance</returns>
        public ToStringRequestBuilder AppendList<T>(string key, List<T> list = null) where T : IRequestStringConvertible
        {
            if (list != null)
            {
                var appendedValue = string.Empty;
                foreach (IRequestStringConvertible value in list)
                {
                    appendedValue = appendedValue + value.ToPkiRequestString() + ", ";
                }

                this.AppendKeyValueArray(key, appendedValue);
            }

            return this;
        }

        /// <summary>
        /// Appends the list.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="list">The list.</param>
        /// <returns>The instance</returns>
        public ToStringRequestBuilder AppendList(string key, List<int> list = null)
        {
            if (list != null)
            {
                var appendedValue = string.Empty;
                foreach (int value in list)
                {
                    appendedValue = appendedValue + value + ", ";
                }

                this.AppendKeyValueArray(key, appendedValue);
            }

            return this;
        }

        /// <summary>
        /// Gets the request string.
        /// </summary>
        /// <returns>The request string</returns>
        public string GetRequestString()
        {
            this.RemoveTrailingComma();
            this.AppendPrefix();
            return this.requestString;
        }

        /// <summary>
        /// Appends the key value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>The instance</returns>
        private ToStringRequestBuilder AppendKeyValue(string key, string value)
        {
            if (value != null)
            {
                this.requestString = this.requestString + key + "=" + value + ",";
            }

            return this;
        }

        /// <summary>
        /// Appends the key value array.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>The instance</returns>
        private ToStringRequestBuilder AppendKeyValueArray(string key, string value)
        {
            if (value != null)
            {
                value = value.Substring(0, value.Length - 2);
                this.requestString = this.requestString + key + "=[" + value + "],";
            }

            return this;
        }

        /// <summary>
        /// Appends the prefix.
        /// </summary>
        /// <returns>The instance</returns>
        private ToStringRequestBuilder AppendPrefix()
        {
            this.requestString = "[" + this.requestString + "]";
            return this;
        }

        /// <summary>
        /// Removes the trailing comma.
        /// </summary>
        /// <returns>The instance</returns>
        private ToStringRequestBuilder RemoveTrailingComma()
        {
            if (!string.IsNullOrEmpty(this.requestString))
            {
                this.requestString = this.requestString.Substring(0, this.requestString.Length - 1);
            }

            return this;
        }
    }
}
