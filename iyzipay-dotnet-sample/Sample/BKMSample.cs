using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;
using System.Collections.Generic;

namespace iyzipay_dotnet_sample.Sample
{
    [TestClass]
    public class BKMSample : Sample
    {
        [TestMethod]
        public void Should_Initialize_Bkm_Express()
        {
            CreateBKMInitializeRequest request = new CreateBKMInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.BasketId = "B67832";
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.Buyer = NewBuyer();
            request.ShippingAddress = newShippingAddress();
            request.BillingAddress = newBillingAddress();
            request.BasketItems = newBasketItems();
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";

            BKMInitialize bkmInitialize = BKMInitialize.Create(request, options);

            Assert.IsNotNull(bkmInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmInitialize.Locale);
            Assert.AreEqual("123456789", bkmInitialize.ConversationId);
            Assert.IsNotNull(bkmInitialize.HtmlContent);
        }

        [TestMethod]
        public void Should_Retrieve_Bkm_Auth()
        {
            RetrieveBKMAuthRequest request = new RetrieveBKMAuthRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Token = "mockToken1453382198111";

            BKMAuth bkmAuth = BKMAuth.Retrieve(request, options);

            Assert.IsNotNull(bkmAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmAuth.Locale);
            Assert.AreEqual("123456789", bkmAuth.ConversationId);
        }

        private Buyer NewBuyer()
        {
            Buyer buyer = new Buyer();
            buyer.Id = "100";
            buyer.Name = "Hakan";
            buyer.Surname = "Erdoğan";
            buyer.IdentityNumber = "16045258606";
            buyer.Email = "email@email.com";
            buyer.GsmNumber = "0553456789";
            buyer.RegistrationDate = "2011-02-17 12:00:00";
            buyer.LastLoginDate = "2015-04-20 12:00:00";
            buyer.RegistrationAddress = "Maltepe";
            buyer.City = "Istanbul";
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34840";
            buyer.Ip = "192.168.123.102";
            return buyer;
        }

        private Address newShippingAddress()
        {
            Address address = new Address();
            address.Description = "Malte Plaza No:56";
            address.ZipCode = "34840";
            address.ContactName = "Hakan";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private Address newBillingAddress()
        {
            Address address = new Address();
            address.Description = "Malte Plaza No:56";
            address.ZipCode = "34840";
            address.ContactName = "Hakan";
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
