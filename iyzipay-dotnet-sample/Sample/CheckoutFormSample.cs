using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Model;
using Iyzipay.Request;
using System.Collections.Generic;

namespace iyzipay_dotnet_sample.Sample
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

            CheckoutFormInitialize checkoutFormInitialize = CheckoutFormInitialize.Create(request, options);
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
            request.Token = "myToken";

            CheckoutFormAuth checkoutFormAuth = CheckoutFormAuth.Retrieve(request, options);
            Assert.IsNotNull(checkoutFormAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), checkoutFormAuth.Status);
            Assert.AreEqual("123456789", checkoutFormAuth.ConversationId);
        }

        private Buyer NewBuyer()
        {
            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "Sabri Onur";
            buyer.Surname = "Tüzün";
            buyer.IdentityNumber = "74300864791";
            buyer.Email = "email@email.com";
            buyer.GsmNumber = "+905350000000";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationAddress = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy";
            buyer.City = "Istanbul";
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34732";
            buyer.Ip = "85.34.78.112";
            return buyer;
        }

        private Address newShippingAddress()
        {
            Address address = new Address();
            address.Description = "19 Mayıs Mah. İnönü Cad. No:45 Kozyatağı";
            address.ZipCode = "34840";
            address.ContactName = "Hakan Erdoğan";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private Address newBillingAddress()
        {
            Address address = new Address();
            address.Description = "19 Mayıs Mah. İnönü Cad. No:45 Kozyatağı";
            address.ZipCode = "34742";
            address.ContactName = "Hakan Erdoğan";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private List<BasketItem> newBasketItems()
        {
            List<BasketItem> paymentBasketItemDtoList = new List<BasketItem>();

            BasketItem firstBasketItem = new BasketItem();
            firstBasketItem.Id = "BI101";
            firstBasketItem.Name = "ABC Marka Kolye";
            firstBasketItem.Category1 = "Giyim";
            firstBasketItem.Category2 = "Aksesuar";
            firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            firstBasketItem.Price = "0.3";
            firstBasketItem.SubMerchantKey = "subMerchantKey";
            firstBasketItem.SubMerchantPrice = "0.27";

            BasketItem secondBasketItem = new BasketItem();
            secondBasketItem.Id = "BI102";
            secondBasketItem.Name = "XYZ Oyun Kodu";
            secondBasketItem.Category1 = "Oyun";
            secondBasketItem.Category2 = "Online Oyun Kodlari";
            secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
            secondBasketItem.Price = "0.5";
            secondBasketItem.SubMerchantKey = "subMerchantKey";
            secondBasketItem.SubMerchantPrice = "0.42";

            BasketItem thirdBasketItem = new BasketItem();
            thirdBasketItem.Id = "BI103";
            thirdBasketItem.Name = "EDC Marka Usb";
            thirdBasketItem.Category1 = "Elektronik";
            thirdBasketItem.Category2 = "Usb / Cable";
            thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            thirdBasketItem.Price = "0.2";
            thirdBasketItem.SubMerchantKey = "subMerchantKey";
            thirdBasketItem.SubMerchantPrice = "0.18";

            paymentBasketItemDtoList.Add(firstBasketItem);
            paymentBasketItemDtoList.Add(secondBasketItem);
            paymentBasketItemDtoList.Add(thirdBasketItem);
            return paymentBasketItemDtoList;
        }
    }
}
