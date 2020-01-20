using Iyzipay.Model;

namespace Iyzipay.Tests.Functional.Builder
{
    public sealed class BuyerBuilder
    {
        private string _id = "BY789";
        private string _name = "John";
        private string _surname = "Doe";
        private string _identityNumber = "74300864791";
        private string _email = "email@email.com";
        private string _gsmNumber = "+905350000000";
        private string _registrationDate = "2013-04-21 15:12:09";
        private string _lastLoginDate = "2015-10-05 12:43:35";
        private string _registrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        private string _city = "Istanbul";
        private string _country = "Turkey";
        private string _zipCode = "34732";
        private string _ip = "85.34.78.112";

        private BuyerBuilder()
        {
        }

        public static BuyerBuilder Create()
        {
            return new BuyerBuilder();
        }

        public BuyerBuilder Id(string id)
        {
            _id = id;
            return this;
        }

        public BuyerBuilder Name(string name)
        {
            _name = name;
            return this;
        }

        public BuyerBuilder Surname(string surname)
        {
            _surname = surname;
            return this;
        }

        public BuyerBuilder IdentityNumber(string identityNumber)
        {
            _identityNumber = identityNumber;
            return this;
        }

        public BuyerBuilder Email(string email)
        {
            _email = email;
            return this;
        }

        public BuyerBuilder GsmNumber(string gsmNumber)
        {
            _gsmNumber = gsmNumber;
            return this;
        }

        public BuyerBuilder RegistrationDate(string registrationDate)
        {
            _registrationDate = registrationDate;
            return this;
        }

        public BuyerBuilder LastLoginDate(string lastLoginDate)
        {
            _lastLoginDate = lastLoginDate;
            return this;
        }

        public BuyerBuilder RegistrationAddress(string registrationAddress)
        {
            _registrationAddress = registrationAddress;
            return this;
        }

        public BuyerBuilder City(string city)
        {
            _city = city;
            return this;
        }

        public BuyerBuilder Country(string country)
        {
            _country = country;
            return this;
        }

        public BuyerBuilder ZipCode(string zipCode)
        {
            _zipCode = zipCode;
            return this;
        }

        public BuyerBuilder Ip(string ip)
        {
            _ip = ip;
            return this;
        }

        public Buyer Build()
        {
            Buyer buyer = new Buyer();
            buyer.Id = _id;
            buyer.Name = _name;
            buyer.Surname = _surname;
            buyer.IdentityNumber = _identityNumber;
            buyer.Email = _email;
            buyer.GsmNumber = _gsmNumber;
            buyer.RegistrationDate = _registrationDate;
            buyer.LastLoginDate = _lastLoginDate;
            buyer.RegistrationAddress = _registrationAddress;
            buyer.City = _city;
            buyer.Country = _country;
            buyer.ZipCode = _zipCode;
            buyer.Ip = _ip;
            return buyer;
        }
    }
}
