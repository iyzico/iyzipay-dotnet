// <copyright file="JsonBuilder.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay
{
    using System.Net.Http;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// JSON builder
    /// </summary>
    public class JsonBuilder
    {
        /// <summary>
        /// Serializes to JSON string.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The request as a string</returns>
        public static string SerializeToJsonString(BaseRequest request)
        {
            return JsonConvert.SerializeObject(
                request,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.None,
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
        }

        /// <summary>
        /// To the JSON string.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The request as a JSON string</returns>
        public static StringContent ToJsonString(BaseRequest request)
        {
            return new StringContent(SerializeToJsonString(request), Encoding.Unicode, "application/json");
        }
    }
}
