// <copyright file="InstallmentInfo.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using System.Collections.Generic;
    using Iyzipay.Request;
    using Newtonsoft.Json;

    /// <summary>
    /// Installment info
    /// </summary>
    /// <seealso cref="Iyzipay.IyzipayResource" />
    public class InstallmentInfo : IyzipayResource
    {
        /// <summary>
        /// Gets or sets the installment details.
        /// </summary>
        /// <value>
        /// The installment details.
        /// </value>
        [JsonProperty(PropertyName = "installmentDetails")]
        public List<InstallmentDetail> InstallmentDetails { get; set; }

        /// <summary>
        /// Retrieves the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static InstallmentInfo Retrieve(RetrieveInstallmentInfoRequest request, Options options)
        {
            return RestHttpClient.Create().Post<InstallmentInfo>(options.BaseUrl + "/payment/iyzipos/installment", IyzipayResource.GetHttpHeaders(request, options), request);
        }
    }
}
