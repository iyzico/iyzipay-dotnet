using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;
using System.Collections.Generic;

namespace IyzipaySample.Sample
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

            PrintResponse<BKMInitialize>(bkmInitialize);

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

            PrintResponse<BKMAuth>(bkmAuth);

            Assert.IsNotNull(bkmAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmAuth.Locale);
            Assert.AreEqual("123456789", bkmAuth.ConversationId);
        }

        private Buyer NewBuyer()
        {
            Buyer buyer = new Buyer();
            buyer.Id = "100";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.IdentityNumber = "74300864791";
            buyer.Email = "email@email.com";
            buyer.GsmNumber = "+905350000000";
            buyer.RegistrationDate = "2011-02-17 12:00:00";
            buyer.LastLoginDate = "2015-04-20 12:00:00";
            buyer.RegistrationAddress = "Address";
            buyer.City = "Istanbul";
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34732";
            buyer.Ip = "85.34.78.12";
            return buyer;
        }

        private Address newShippingAddress()
        {
            Address address = new Address();
            address.Description = "Address";
            address.ZipCode = "34742";
            address.ContactName = "Jane Doe";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private Address newBillingAddress()
        {
            Address address = new Address();
            address.Description = "Address";
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
