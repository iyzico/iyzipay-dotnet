// <copyright file="BasicPayment.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Model
{
    using Iyzipay.Request;

    /// <summary>
    /// Basic payment
    /// </summary>
    /// <seealso cref="Iyzipay.Model.BasicPaymentResource" />
    public class BasicPayment : BasicPaymentResource
    {
        /// <summary>
        /// Creates the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options.</param>
        /// <returns>The response</returns>
        public static BasicPayment Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPayment>(options.BaseUrl + "/payment/auth/basic", BasicPayment.GetHttpHeaders(request, options), request);
        }
    }
}
