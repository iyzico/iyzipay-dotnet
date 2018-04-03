using System.Collections.Generic;
using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Util;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public class CreatePeccoInitializeRequestBuilder : BaseRequestBuilder
    {
        private string _currency = Model.Currency.IRR.ToString();
        private string _basketId = RandomGenerator.RandomId;
        private string _paymentGroup;
        private Buyer _buyer = BuyerBuilder.Create().Build();
        private Address _shippingAddress = AddressBuilder.Create().Build();
        private Address _billingAddress = AddressBuilder.Create().Build();
        private string _paymentSource;
        private List<BasketItem> _basketItems = BasketItemBuilder.Create().BuildDefaultBasketItems();
        private string _callbackUrl;
        private string _paidPrice;
        private string _price;

        private CreatePeccoInitializeRequestBuilder()
        {
        }

        public static CreatePeccoInitializeRequestBuilder Create()
        {
            return new CreatePeccoInitializeRequestBuilder();
        }

        public CreatePeccoInitializeRequestBuilder Price(string price)
        {
            _price = price;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder PaidPrice(string paidPrice)
        {
            _paidPrice = paidPrice;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder Currency(string currency)
        {
            _currency = currency;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder BasketId(string basketId)
        {
            _basketId = basketId;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder PaymentGroup(string paymentGroup)
        {
            _paymentGroup = paymentGroup;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder PaymentSource(string paymentSource)
        {
            _paymentSource = paymentSource;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder Buyer(Buyer buyer)
        {
            _buyer = buyer;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder ShippingAddress(Address shippingAddress)
        {
            _shippingAddress = shippingAddress;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder BillingAddress(Address billingAddress)
        {
            _billingAddress = billingAddress;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder BasketItems(List<BasketItem> basketItems)
        {
            _basketItems = basketItems;
            return this;
        }

        public CreatePeccoInitializeRequestBuilder CallbackUrl(string callbackUrl)
        {
            _callbackUrl = callbackUrl;
            return this;
        }

        public CreatePeccoInitializeRequest Build()
        {
            CreatePeccoInitializeRequest createPeccoInitializeRequest = new CreatePeccoInitializeRequest();
            createPeccoInitializeRequest.Locale = Locale;
            createPeccoInitializeRequest.ConversationId = ConversationId;
            createPeccoInitializeRequest.Price = _price;
            createPeccoInitializeRequest.PaidPrice = _paidPrice;
            createPeccoInitializeRequest.Currency = _currency;
            createPeccoInitializeRequest.BasketId = _basketId;
            createPeccoInitializeRequest.PaymentGroup = _paymentGroup;
            createPeccoInitializeRequest.PaymentSource = _paymentSource;
            createPeccoInitializeRequest.Buyer = _buyer;
            createPeccoInitializeRequest.ShippingAddress = _shippingAddress;
            createPeccoInitializeRequest.BillingAddress = _billingAddress;
            createPeccoInitializeRequest.BasketItems = _basketItems;
            createPeccoInitializeRequest.CallbackUrl = _callbackUrl;
            return createPeccoInitializeRequest;
        }
    }
}
