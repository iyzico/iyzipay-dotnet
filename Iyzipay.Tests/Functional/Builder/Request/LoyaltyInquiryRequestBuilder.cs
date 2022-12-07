using System.Collections.Generic;
using System.Linq;
using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Util;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class LoyaltyInquiryRequestBuilder : BaseRequestBuilder
    {
        private LoyaltyPaymentCard _loyaltyPaymentCard = LoyaltyPaymentCardBuilder.Create().BuildWithCardCredentials().Build();
        private string _currency;

        private LoyaltyInquiryRequestBuilder()
        {
        }

        public static LoyaltyInquiryRequestBuilder Create()
        {
            return new LoyaltyInquiryRequestBuilder();
        }

        public LoyaltyInquiryRequestBuilder Currency(string currency)
        {
            this._currency = currency;
            return this;
        }

        public LoyaltyInquiryRequest Build()
        {
            LoyaltyInquiryRequest loyaltyInquiryRequest = new LoyaltyInquiryRequest();
            loyaltyInquiryRequest.Locale =  _locale;
            loyaltyInquiryRequest.ConversationId = _conversationId;
            loyaltyInquiryRequest.PaymentCard = _loyaltyPaymentCard;
            loyaltyInquiryRequest.Currency = _currency;
            return loyaltyInquiryRequest;
        }
    }
}
