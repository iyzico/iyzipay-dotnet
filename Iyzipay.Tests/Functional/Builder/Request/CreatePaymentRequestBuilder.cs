using System.Collections.Generic;
using Iyzipay.Model;
using Iyzipay.Request;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public sealed class CreatePaymentRequestBuilder : BaseRequestBuilder
    {
        private string _price = "1";
        private string _paidPrice = "1.1";
        private int _installment = 1;
        private string _paymentChannel = Model.PaymentChannel.WEB.ToString();
        private string _basketId = "B67832";
        private string _paymentGroup;
        private Buyer _buyer = BuyerBuilder.Create().Build();
        private Address _shippingAddress = AddressBuilder.Create().Build();
        private Address _billingAddress = AddressBuilder.Create().Build();
        private List<BasketItem> _basketItems;
        private string _currency = Model.Currency.TRY.ToString();
        private PaymentCard _paymentCard = PaymentCardBuilder.Create().BuildWithCardCredentials().Build();
        private string _paymentSource;
        private string _callbackUrl;
        private string _posOrderId;
        private string _connectorName;

        private CreatePaymentRequestBuilder()
        {
        }

        public static CreatePaymentRequestBuilder Create()
        {
            return new CreatePaymentRequestBuilder();
        }

        public CreatePaymentRequestBuilder Locale(string locale)
        {
            base._locale = locale;
            return this;
        }

        public CreatePaymentRequestBuilder ConversationId(string conversationId)
        {
            base._conversationId = conversationId;
            return this;
        }

        public CreatePaymentRequestBuilder Price(string price)
        {
            _price = price;
            return this;
        }

        public CreatePaymentRequestBuilder PaidPrice(string paidPrice)
        {
            _paidPrice = paidPrice;
            return this;
        }

        public CreatePaymentRequestBuilder Installment(int installment)
        {
            _installment = installment;
            return this;
        }

        public CreatePaymentRequestBuilder PaymentChannel(string paymentChannel)
        {
            _paymentChannel = paymentChannel;
            return this;
        }

        public CreatePaymentRequestBuilder BasketId(string basketId)
        {
            _basketId = basketId;
            return this;
        }

        public CreatePaymentRequestBuilder PaymentGroup(string paymentGroup)
        {
            _paymentGroup = paymentGroup;
            return this;
        }

        public CreatePaymentRequestBuilder PaymentCard(PaymentCard paymentCard)
        {
            _paymentCard = paymentCard;
            return this;
        }

        public CreatePaymentRequestBuilder Buyer(Buyer buyer)
        {
            _buyer = buyer;
            return this;
        }

        public CreatePaymentRequestBuilder ShippingAddress(Address shippingAddress)
        {
            _shippingAddress = shippingAddress;
            return this;
        }

        public CreatePaymentRequestBuilder BillingAddress(Address billingAddress)
        {
            _billingAddress = billingAddress;
            return this;
        }

        public CreatePaymentRequestBuilder BasketItems(List<BasketItem> basketItems)
        {
            _basketItems = basketItems;
            return this;
        }

        public CreatePaymentRequestBuilder PaymentSource(string paymentSource)
        {
            _paymentSource = paymentSource;
            return this;
        }

        public CreatePaymentRequestBuilder CallbackUrl(string callbackUrl)
        {
            _callbackUrl = callbackUrl;
            return this;
        }

        public CreatePaymentRequestBuilder PosOrderId(string posOrderId)
        {
            _posOrderId = posOrderId;
            return this;
        }

        public CreatePaymentRequestBuilder ConnectorName(string connectorName)
        {
            _connectorName = connectorName;
            return this;
        }

        public CreatePaymentRequestBuilder Currency(string currency)
        {
            _currency = currency;
            return this;
        }

        public CreatePaymentRequest Build()
        {
            CreatePaymentRequest createPaymentRequest = new CreatePaymentRequest();
            createPaymentRequest.Locale = base._locale;
            createPaymentRequest.ConversationId = base._conversationId;
            createPaymentRequest.Price = _price;
            createPaymentRequest.PaidPrice = _paidPrice;
            createPaymentRequest.Installment = _installment;
            createPaymentRequest.PaymentChannel = _paymentChannel;
            createPaymentRequest.BasketId = _basketId;
            createPaymentRequest.PaymentGroup = _paymentGroup;
            createPaymentRequest.PaymentCard =_paymentCard;
            createPaymentRequest.Buyer = _buyer;
            createPaymentRequest.ShippingAddress = _shippingAddress;
            createPaymentRequest.BillingAddress = _billingAddress;
            createPaymentRequest.BasketItems = _basketItems;
            createPaymentRequest.PaymentSource = _paymentSource;
            createPaymentRequest.CallbackUrl = _callbackUrl;
            createPaymentRequest.PosOrderId = _posOrderId;
            createPaymentRequest.ConnectorName = _connectorName;
            createPaymentRequest.Currency = _currency;
            return createPaymentRequest;
        }

        public CreatePaymentRequestBuilder MarketplacePayment(string subMerchantKey)
        {
            _basketItems = BasketItemBuilder.Create().BuildBasketItemsWithSubMerchantKey(subMerchantKey);
            _paymentGroup = Model.PaymentGroup.PRODUCT.ToString();
            return this;
        }

        public CreatePaymentRequestBuilder StandardListingPayment()
        {
            _basketItems = BasketItemBuilder.Create().BuildDefaultBasketItems();
            _paymentGroup = Model.PaymentGroup.LISTING.ToString();
            return this;
        }
    }
}
