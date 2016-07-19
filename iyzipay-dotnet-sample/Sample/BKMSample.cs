// <copyright file="BkmSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using System.Collections.Generic;
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// BKM Sample
    /// </summary>
    [TestClass]
    public class BkmSample : Sample
    {
        /// <summary>
        /// Should initialize BKM express.
        /// </summary>
        [TestMethod]
        public void ShouldInitializeBkmExpress()
        {
            var request = new CreateBkmInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.BasketId = "B67832";
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.Buyer = this.NewBuyer();
            request.ShippingAddress = this.NewShippingAddress();
            request.BillingAddress = this.NewBillingAddress();
            request.BasketItems = this.NewBasketItems();
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";

            var bkmInitialize = BkmInitialize.Create(request, Options);

            this.PrintResponse<BkmInitialize>(bkmInitialize);

            Assert.IsNotNull(bkmInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmInitialize.Locale);
            Assert.AreEqual("123456789", bkmInitialize.ConversationId);
            Assert.IsNotNull(bkmInitialize.HtmlContent);
        }

        /// <summary>
        /// Should retrieve BKM authentication.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveBkmAuth()
        {
            var request = new RetrieveBkmRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Token = "mockToken1453382198111";

            var bkmAuth = Bkm.Retrieve(request, Options);

            this.PrintResponse<Bkm>(bkmAuth);

            Assert.IsNotNull(bkmAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmAuth.Locale);
            Assert.AreEqual("123456789", bkmAuth.ConversationId);
        }

        /// <summary>
        /// Creates a new buyer.
        /// </summary>
        /// <returns>The buyer</returns>
        private Buyer NewBuyer()
        {
            var buyer = new Buyer();
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

        /// <summary>
        /// Creates a new shipping address.
        /// </summary>
        /// <returns>The shipping address</returns>
        private Address NewShippingAddress()
        {
            var address = new Address();
            address.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            address.ZipCode = "34742";
            address.ContactName = "Jane Doe";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        /// <summary>
        /// Creates a new billing address.
        /// </summary>
        /// <returns>The billing address</returns>
        private Address NewBillingAddress()
        {
            var address = new Address();
            address.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            address.ZipCode = "34742";
            address.ContactName = "Jane Doe";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        /// <summary>
        /// Creates new basket items.
        /// </summary>
        /// <returns>The basket items</returns>
        private List<BasketItem> NewBasketItems()
        {
            var basketItems = new List<BasketItem>();

            var firstBasketItem = new BasketItem();
            firstBasketItem.Id = "BI101";
            firstBasketItem.Name = "Binocular";
            firstBasketItem.Category1 = "Collectibles";
            firstBasketItem.Category2 = "Accessories";
            firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            firstBasketItem.Price = "0.3";
            firstBasketItem.SubMerchantKey = "sub merchant key";
            firstBasketItem.SubMerchantPrice = "0.27";
            basketItems.Add(firstBasketItem);

            var secondBasketItem = new BasketItem();
            secondBasketItem.Id = "BI102";
            secondBasketItem.Name = "Game code";
            secondBasketItem.Category1 = "Game";
            secondBasketItem.Category2 = "Online Game Items";
            secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
            secondBasketItem.Price = "0.5";
            secondBasketItem.SubMerchantKey = "sub merchant key";
            secondBasketItem.SubMerchantPrice = "0.42";
            basketItems.Add(secondBasketItem);

            var thirdBasketItem = new BasketItem();
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
