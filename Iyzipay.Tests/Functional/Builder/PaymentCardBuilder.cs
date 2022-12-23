using Iyzipay.Model;

namespace Iyzipay.Tests.Functional.Builder
{
    public sealed class PaymentCardBuilder
    {
        private string _cardHolderName;
        private string _cardNumber;
        private string _expireYear;
        private string _expireMonth;
        private string _cvc;
        private int _registerCard = 0;
        private string _cardAlias;
        private string _cardToken;
        private string _cardUserKey;

        private PaymentCardBuilder()
        {
        }

        public static PaymentCardBuilder Create()
        {
            return new PaymentCardBuilder();
        }

        public PaymentCardBuilder CardHolderName(string cardHolderName)
        {
            _cardHolderName = cardHolderName;
            return this;
        }

        public PaymentCardBuilder CardNumber(string cardNumber)
        {
            _cardNumber = cardNumber;
            return this;
        }

        public PaymentCardBuilder ExpireYear(string expireYear)
        {
            _expireYear = expireYear;
            return this;
        }

        public PaymentCardBuilder ExpireMonth(string expireMonth)
        {
            _expireMonth = expireMonth;
            return this;
        }

        public PaymentCardBuilder Cvc(string cvc)
        {
            _cvc = cvc;
            return this;
        }

        public PaymentCardBuilder RegisterCard(int registerCard)
        {
            _registerCard = registerCard;
            return this;
        }

        public PaymentCardBuilder CardAlias(string cardAlias)
        {
            _cardAlias = cardAlias;
            return this;
        }

        public PaymentCardBuilder CardToken(string cardToken)
        {
            _cardToken = cardToken;
            return this;
        }

        public PaymentCardBuilder CardUserKey(string cardUserKey)
        {
            _cardUserKey = cardUserKey;
            return this;
        }

        public PaymentCard Build()
        {
            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = _cardHolderName;
            paymentCard.CardNumber = _cardNumber;
            paymentCard.ExpireYear = _expireYear;
            paymentCard.ExpireMonth = _expireMonth;
            paymentCard.Cvc = _cvc;
            paymentCard.RegisterCard = _registerCard;
            paymentCard.CardAlias = _cardAlias;
            paymentCard.CardToken = _cardToken;
            paymentCard.CardUserKey = _cardUserKey;
            return paymentCard;
        }

        public PaymentCardBuilder BuildWithCardCredentials()
        {
            _cardHolderName = "John Doe";
            _cardNumber = "5528790000000008";
            _expireYear = "2030";
            _expireMonth = "12";
            _cvc = "123";
            _cardAlias = "card alias";
            return this;
        }

        public PaymentCardBuilder BuildWithYKBCardCredentials()
        {
            _cardHolderName = "John Doe";
            _cardNumber = "5451030000000000";
            _expireYear = "2030";
            _expireMonth = "09";
            _cvc = "711";
            _cardAlias = "card alias";
            return this;
        }

        public PaymentCardBuilder BuildWithDenizBankCardCredentials()
        {
            _cardHolderName = "John Doe";
            _cardNumber = "5549607159333771";
            _expireYear = "2030";
            _expireMonth = "09";
            _cvc = "711";
            _cardAlias = "card alias";
            return this;
        }
    }
}
