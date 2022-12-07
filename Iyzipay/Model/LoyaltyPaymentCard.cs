using System;

namespace Iyzipay.Model
{
    public class LoyaltyPaymentCard : RequestStringConvertible
    {
        public string CardHolderName { set; get; }
        public string CardNumber { set; get; }
        public string ExpireYear { set; get; }
        public string ExpireMonth { set; get; }
        public string Cvc { set; get; }
        public string CardUserKey { set; get; }
        public string CardToken { set; get; }

        public string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("cardHolderName", CardHolderName)
                .Append("cardNumber", CardNumber)
                .Append("expireYear", ExpireYear)
                .Append("expireMonth", ExpireMonth)
                .Append("cvc", Cvc)
                .Append("cardToken", CardToken)
                .Append("cardUserKey", CardUserKey)
                .GetRequestString();
        }
    }
}
