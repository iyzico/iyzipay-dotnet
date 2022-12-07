using Iyzipay.Model;

namespace Iyzipay.Tests.Functional.Builder
{
    public sealed class LoyaltyPaymentCardBuilder
    {
        private string _cardHolderName;
        private string _cardNumber;
        private string _expireYear;
        private string _expireMonth;
        private string _cvc;
        private string _cardToken;
        private string _cardUserKey;

        private LoyaltyPaymentCardBuilder()
        {
        }

        public static LoyaltyPaymentCardBuilder Create()
        {
            return new LoyaltyPaymentCardBuilder();
        }

        public LoyaltyPaymentCardBuilder CardHolderName(string cardHolderName)
        {
            _cardHolderName = cardHolderName;
            return this;
        }

        public LoyaltyPaymentCardBuilder CardNumber(string cardNumber)
        {
            _cardNumber = cardNumber;
            return this;
        }

        public LoyaltyPaymentCardBuilder ExpireYear(string expireYear)
        {
            _expireYear = expireYear;
            return this;
        }

        public LoyaltyPaymentCardBuilder ExpireMonth(string expireMonth)
        {
            _expireMonth = expireMonth;
            return this;
        }

        public LoyaltyPaymentCardBuilder Cvc(string cvc)
        {
            _cvc = cvc;
            return this;
        }


        public LoyaltyPaymentCardBuilder CardToken(string cardToken)
        {
            _cardToken = cardToken;
            return this;
        }

        public LoyaltyPaymentCardBuilder CardUserKey(string cardUserKey)
        {
            _cardUserKey = cardUserKey;
            return this;
        }

        public LoyaltyPaymentCard Build()
        {
            LoyaltyPaymentCard paymentCard = new LoyaltyPaymentCard();
            paymentCard.CardHolderName = _cardHolderName;
            paymentCard.CardNumber = _cardNumber;
            paymentCard.ExpireYear = _expireYear;
            paymentCard.ExpireMonth = _expireMonth;
            paymentCard.Cvc = _cvc;
            paymentCard.CardToken = _cardToken;
            paymentCard.CardUserKey = _cardUserKey;
            return paymentCard;
        }

        public LoyaltyPaymentCardBuilder BuildWithCardCredentials()
        {
            _cardHolderName = "John Doe";
            _cardNumber = "5451030000000000";
            _expireYear = "2023";
            _expireMonth = "09";
            _cvc = "123";
            //_cardUserKey = "card user key";
            //_cardToken = "card token";
            return this;
        }
    }
}
