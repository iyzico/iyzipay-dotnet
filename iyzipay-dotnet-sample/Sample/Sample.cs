// <copyright file="Sample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using System.Diagnostics;
    using Iyzipay;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// The sample
    /// </summary>
    [TestClass]
    public class Sample
    {
        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public Options Options { get; set; }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this.Options = new Options
            {
                ApiKey = "apiKey",
                SecretKey = "secretKey",
                BaseUrl = "baseUrl"
            };
        }

        /// <summary>
        /// Prints the response.
        /// </summary>
        /// <typeparam name="T">The type parameter</typeparam>
        /// <param name="resource">The resource.</param>
        protected void PrintResponse<T>(T resource)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine(JsonConvert.SerializeObject(
                resource,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                }));
        }
    }
}
