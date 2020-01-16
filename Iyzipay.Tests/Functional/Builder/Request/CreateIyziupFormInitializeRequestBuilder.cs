using System;
using System.Collections.Generic;
using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Util;

namespace Iyzipay.Tests.Functional.Builder.Request
{
    public class CreateIyziupFormInitializeRequestBuilder : BaseRequestBuilder
    {
        private string _merchantOrderId = RandomGenerator.RandomId;
        private string _paymentGroup = Model.PaymentGroup.LISTING.ToString();
        private string _paymentSource;
        private string _currency = Model.Currency.TRY.ToString();
        private int _forceThreeDS;
        private List<int> _enabledInstallments = new List<int>() {2, 3, 6, 9};
        private string _enabledCardFamily;
        private string _price;
        private string _paidPrice;
        private string _shippingPrice;
        private string _callbackUrl;
        private string _termsUrl;
        private string _preSalesContractUrl;
        private List<OrderItem> _orderItems;
        private InitialConsumer _initialConsumer;
        
        private CreateIyziupFormInitializeRequestBuilder()
        {
        }
        
        public static CreateIyziupFormInitializeRequestBuilder Create()
        {
            return new CreateIyziupFormInitializeRequestBuilder();
        }
        
        public CreateIyziupFormInitializeRequestBuilder MerchantOrderId(string merchantOrderId)
        {
            this._merchantOrderId = merchantOrderId;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder PaymentGroup(string paymentGroup)
        {
            this._paymentGroup = paymentGroup;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder PaymentSource(string paymentSource)
        {
            this._paymentSource = paymentSource;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder Currency(string currency)
        {
            this._currency = currency;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder ForceThreeDs(int forceThreeDs)
        {
            this._forceThreeDS = forceThreeDs;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder EnabledInstallments(List<int> enabledInstallments)
        {
            this._enabledInstallments = enabledInstallments;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder EnabledCardFamily(string enabledCardFamily)
        {
            this._enabledCardFamily = enabledCardFamily;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder Price(string price)
        {
            this._price = price;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder PaidPrice(string paidPrice)
        {
            this._paidPrice = paidPrice;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder ShippingPrice(string shippingPrice)
        {
            this._shippingPrice = shippingPrice;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder CallbackUrl(string callbackUrl)
        {
            this._callbackUrl = callbackUrl;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder TermsUrl(string termsUrl)
        {
            this._termsUrl = termsUrl;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder PreSalesContractUrl(string preSalesContractUrl)
        {
            this._preSalesContractUrl = preSalesContractUrl;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder OrderItems(List<OrderItem> orderItems)
        {
            this._orderItems = orderItems;
            return this;
        }
        
        public CreateIyziupFormInitializeRequestBuilder InitialConsumer(InitialConsumer initialConsumer)
        {
            this._initialConsumer = initialConsumer;
            return this;
        }
        
        public CreateIyziupFormInitializeRequest Build()
        {
            CreateIyziupFormInitializeRequest createIyziupFormInitializeRequest = new CreateIyziupFormInitializeRequest();
            createIyziupFormInitializeRequest.MerchantOrderId =  _merchantOrderId;
            createIyziupFormInitializeRequest.PaymentGroup = _paymentGroup;
            createIyziupFormInitializeRequest.PaymentSource = _paymentSource;
            createIyziupFormInitializeRequest.Currency = _currency;
            createIyziupFormInitializeRequest.EnabledInstallments = _enabledInstallments;
            createIyziupFormInitializeRequest.EnabledCardFamily = _enabledCardFamily;
            createIyziupFormInitializeRequest.Price = _price;
            createIyziupFormInitializeRequest.PaidPrice = _paidPrice;
            createIyziupFormInitializeRequest.ShippingPrice = _shippingPrice;
            createIyziupFormInitializeRequest.CallbackUrl= _callbackUrl;
            createIyziupFormInitializeRequest.TermsUrl = _termsUrl;
            createIyziupFormInitializeRequest.PreSalesContractUrl = _preSalesContractUrl;
            createIyziupFormInitializeRequest.ForceThreeDS = _forceThreeDS;
            createIyziupFormInitializeRequest.OrderItems = _orderItems;
            createIyziupFormInitializeRequest.InitialConsumer = _initialConsumer;
            return createIyziupFormInitializeRequest;
        }
    }
}