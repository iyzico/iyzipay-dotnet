// <copyright file="CreateApprovalRequest.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace Iyzipay.Request
{
    /// <summary>
    /// Create approval request
    /// </summary>
    /// <seealso cref="Iyzipay.BaseRequest" />
    public class CreateApprovalRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the payment transaction identifier.
        /// </summary>
        /// <value>
        /// The payment transaction identifier.
        /// </value>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// To PKI request string.
        /// </summary>
        /// <returns>
        /// The request as a PKI string
        /// </returns>
        public override string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentTransactionId", this.PaymentTransactionId)
                .GetRequestString();
        }
    }
}
