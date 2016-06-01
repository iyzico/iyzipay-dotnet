using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Model;
using Iyzipay.Request;
using System.Collections.Generic;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class CheckoutFormSample : Sample
    {
        [TestMethod]
        public void Should_Initialize_Checkout_Form()
        {
            CreateCheckoutFormInitializeRequest request = new CreateCheckoutFormInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.2";
            request.BasketId = "B67832";
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.Buyer = NewBuyer();
            request.ShippingAddress = newShippingAddress();
            request.BillingAddress = newBillingAddress();
            request.BasketItems = newBasketItems();
            request.CallbackUrl = "https://www.merchant.com/callback";
            request.Currency = Currency.TRY.ToString();

            CheckoutFormInitialize checkoutFormInitialize = CheckoutFormInitialize.Create(request, options);

            PrintResponse<CheckoutFormInitialize>(checkoutFormInitialize);

            Assert.IsNotNull(checkoutFormInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), checkoutFormInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), checkoutFormInitialize.Locale);
            Assert.AreEqual("123456789", checkoutFormInitialize.ConversationId);
        }

        [TestMethod]
        public void Should_Retrieve_Checkout_Form_Auth()
        {
            RetrieveCheckoutFormAuthRequest request = new RetrieveCheckoutFormAuthRequest();
            request.ConversationId = "123456789";
            request.Token = "token";

            CheckoutFormAuth checkoutFormAuth = CheckoutFormAuth.Retrieve(request, options);

            PrintResponse<CheckoutFormAuth>(checkoutFormAuth);

            Assert.IsNotNull(checkoutFormAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), checkoutFormAuth.Status);
            Assert.AreEqual("123456789", checkoutFormAuth.ConversationId);
        }

        private Buyer NewBuyer()
        {
            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.IdentityNumber = "74300864791";
            buyer.Email = "email@email.com";
            buyer.GsmNumber = "+905350000000";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.City = "Istanbul";
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34732";
            buyer.Ip = "85.34.78.112";
            return buyer;
        }

        private Address newShippingAddress()
        {
            Address address = new Address();
            address.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            address.ZipCode = "34742";
            address.ContactName = "Jane Doe";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private Address newBillingAddress()
        {
            Address address = new Address();
            address.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            address.ZipCode = "34742";
            address.ContactName = "Jane Doe";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private List<BasketItem> newBasketItems()
        {
            List<BasketItem> basketItems = new List<BasketItem>();

            BasketItem firstBasketItem = new BasketItem();
            firstBasketItem.Id = "BI101";
            firstBasketItem.Name = "Binocular";
            firstBasketItem.Category1 = "Collectibles";
            firstBasketItem.Category2 = "Accessories";
            firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            firstBasketItem.Price = "0.3";
            firstBasketItem.SubMerchantKey = "sub merchant key";
            firstBasketItem.SubMerchantPrice = "0.27";
            basketItems.Add(firstBasketItem);

            BasketItem secondBasketItem = new BasketItem();
            secondBasketItem.Id = "BI102";
            secondBasketItem.Name = "Game code";
            secondBasketItem.Category1 = "Game";
            secondBasketItem.Category2 = "Online Game Items";
            secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
            secondBasketItem.Price = "0.5";
            secondBasketItem.SubMerchantKey = "sub merchant key";
            secondBasketItem.SubMerchantPrice = "0.42";
            basketItems.Add(secondBasketItem);

            BasketItem thirdBasketItem = new BasketItem();
            thirdBasketItem.Id = "BI103";
            thirdBasketItem.Name = "Usb";
            thirdBasketItem.Category1 = "Electronics";
            thirdBasketItem.Category2 = "Usb / Cable";
            thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            thirdBasketItem.Price = "0.2";
            thirdBasketItem.SubMerchantKey = "sub merchant key";
            thirdBasketItem.SubMerchantPrice = "0.18";
            basketItems.Add(thirdBasketItem);

            return basketItems;
        }
    }
}
