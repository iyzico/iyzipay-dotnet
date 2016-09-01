using Iyzipay.Request;
using Iyzipay.Model;
using System.Collections.Generic;
using NUnit.Framework;

namespace IyzipaySample.Sample
{
    public class BkmSample : Sample
    {
        [Test]
        public void Should_Initialize_Bkm()
        {
            CreateBkmInitializeRequest request = new CreateBkmInitializeRequest();
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

            BkmInitialize bkmInitialize = BkmInitialize.Create(request, options);

            PrintResponse<BkmInitialize>(bkmInitialize);

            Assert.IsNotNull(bkmInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmInitialize.Locale);
            Assert.AreEqual("123456789", bkmInitialize.ConversationId);
            Assert.IsNotNull(bkmInitialize.HtmlContent);
        }

        [Test]
        public void Should_Retrieve_Bkm_Result()
        {
            RetrieveBkmRequest request = new RetrieveBkmRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Token = "token";

            Bkm bkm = Bkm.Retrieve(request, options);

            PrintResponse<Bkm>(bkm);

            Assert.IsNotNull(bkm.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkm.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkm.Locale);
            Assert.AreEqual("123456789", bkm.ConversationId);
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
            buyer.RegistrationDate = "2011-02-17 12:00:00";
            buyer.LastLoginDate = "2015-04-20 12:00:00";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.City = "Istanbul";
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34732";
            buyer.Ip = "85.34.78.12";
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
            basketItems.Add(firstBasketItem);

            BasketItem secondBasketItem = new BasketItem();
            secondBasketItem.Id = "BI102";
            secondBasketItem.Name = "Game code";
            secondBasketItem.Category1 = "Game";
            secondBasketItem.Category2 = "Online Game Items";
            secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
            secondBasketItem.Price = "0.5";
            basketItems.Add(secondBasketItem);

            BasketItem thirdBasketItem = new BasketItem();
            thirdBasketItem.Id = "BI103";
            thirdBasketItem.Name = "Usb";
            thirdBasketItem.Category1 = "Electronics";
            thirdBasketItem.Category2 = "Usb / Cable";
            thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            thirdBasketItem.Price = "0.2";
            basketItems.Add(thirdBasketItem);

            return basketItems;
        }
    }
}
