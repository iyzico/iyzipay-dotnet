// <copyright file="CheckoutFormPreAuthSample.cs" company="Iyzico">
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
    /// Checkout Form Pre Authorization Sample
    /// </summary>
    [TestClass]
    public class CheckoutFormPreAuthSample : Sample
    {
        /// <summary>
        /// Should initialize checkout form.
        /// </summary>
        [TestMethod]
        public void ShouldInitializeCheckoutForm()
        {
            var request = new CreateCheckoutFormInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.2";
            request.BasketId = "B67832";
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.Buyer = this.NewBuyer();
            request.ShippingAddress = this.NewShippingAddress();
            request.BillingAddress = this.NewBillingAddress();
            request.BasketItems = this.NewBasketItems();
            request.CallbackUrl = "https://www.merchant.com/callback";
            request.EnabledInstallments = this.NewEnabledInstallments();

            var checkoutFormInitializePreAuth = CheckoutFormInitializePreAuth.Create(request, Options);

            this.PrintResponse<CheckoutFormInitializePreAuth>(checkoutFormInitializePreAuth);

            Assert.IsNotNull(checkoutFormInitializePreAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), checkoutFormInitializePreAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), checkoutFormInitializePreAuth.Locale);
            Assert.AreEqual("123456789", checkoutFormInitializePreAuth.ConversationId);
        }

        /// <summary>
        /// Should retrieve checkout form.
        /// </summary>
        [TestMethod]
        public void ShouldRetrieveCheckoutForm()
        {
            var request = new RetrieveCheckoutFormRequest();
            request.ConversationId = "123456789";
            request.Token = "token";

            var checkoutForm = CheckoutForm.Retrieve(request, Options);

            this.PrintResponse<CheckoutForm>(checkoutForm);

            Assert.IsNotNull(checkoutForm.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), checkoutForm.Status);
            Assert.AreEqual("123456789", checkoutForm.ConversationId);
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
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.City = "Istanbul";
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34732";
            buyer.Ip = "85.34.78.112";
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
        /// Creates a new basket items.
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
            basketItems.Add(firstBasketItem);

            var secondBasketItem = new BasketItem();
            secondBasketItem.Id = "BI102";
            secondBasketItem.Name = "Game code";
            secondBasketItem.Category1 = "Game";
            secondBasketItem.Category2 = "Online Game Items";
            secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
            secondBasketItem.Price = "0.5";
            basketItems.Add(secondBasketItem);

            var thirdBasketItem = new BasketItem();
            thirdBasketItem.Id = "BI103";
            thirdBasketItem.Name = "Usb";
            thirdBasketItem.Category1 = "Electronics";
            thirdBasketItem.Category2 = "Usb / Cable";
            thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            thirdBasketItem.Price = "0.2";
            basketItems.Add(thirdBasketItem);

            return basketItems;
        }

        /// <summary>
        /// Creates enabled installments.
        /// </summary>
        /// <returns>The enabled installments</returns>
        private List<int> NewEnabledInstallments()
        {
            var enabledInstallments = new List<int>();
            enabledInstallments.Add(2);
            enabledInstallments.Add(3);
            enabledInstallments.Add(6);
            enabledInstallments.Add(9);
            return enabledInstallments;
        }
    }
}
