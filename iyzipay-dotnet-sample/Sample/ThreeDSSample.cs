// <copyright file="ThreedsSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Iyzipay.Model;
    using Iyzipay.Request;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// 3D-secure sample
    /// </summary>
    [TestClass]
    public class ThreedsSample : Sample
    {
        /// <summary>
        /// Should initialize three ds payment with physical and virtual item for standard merchant.
        /// </summary>
        [TestMethod]
        public void ShouldInitializeThreeDSPaymentWithPhysicalAndVirtualItemForStandardMerchant()
        {
            var request = new CreatePaymentRequest();

            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.1";
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.CallbackUrl = "http://www.merchant.com/callbackUrl";
            request.Currency = Currency.TRY.ToString();

            var paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            var buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "İstanbul";
            buyer.Country = "Türkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            var shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "İstanbul";
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            var billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "İstanbul";
            billingAddress.Country = "Türkiye";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

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
            request.BasketItems = basketItems;

            var threedsInitialize = ThreedsInitialize.Create(request, Options);

            this.PrintResponse<ThreedsInitialize>(threedsInitialize);

            Assert.IsNotNull(threedsInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), threedsInitialize.Locale);
            Assert.AreEqual("123456789", threedsInitialize.ConversationId);
        }

        /// <summary>
        /// Should initialize three ds payment with physical and virtual item for market place.
        /// </summary>
        [TestMethod]
        public void ShouldInitializeThreeDSPaymentWithPhysicalAndVirtualItemForMarketPlace()
        {
            var request = new CreatePaymentRequest();

            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.1";
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.CallbackUrl = "http://www.merchant.com/callbackUrl";
            request.Currency = Currency.TRY.ToString();

            var paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            var buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "İstanbul";
            buyer.Country = "Türkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            var shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "İstanbul";
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            var billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "İstanbul";
            billingAddress.Country = "Türkiye";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

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
            request.BasketItems = basketItems;

            var threedsInitialize = ThreedsInitialize.Create(request, Options);

            this.PrintResponse<ThreedsInitialize>(threedsInitialize);

            Assert.IsNotNull(threedsInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), threedsInitialize.Locale);
            Assert.AreEqual("123456789", threedsInitialize.ConversationId);
        }

        /// <summary>
        /// Should initialize 3D-secure payment with physical and virtual item for listing or subscription.
        /// </summary>
        [TestMethod]
        public void ShouldInitializeThreeDSPaymentWithPhysicalAndVirtualItemForListingOrSubscription()
        {
            var request = new CreatePaymentRequest();

            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.1";
            request.Installment = 3;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.LISTING.ToString();
            request.CallbackUrl = "https://www.merchant.com/callback";
            request.Currency = Currency.TRY.ToString();

            var paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            var buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "İstanbul";
            buyer.Country = "Türkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            var shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "İstanbul";
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            var billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "İstanbul";
            billingAddress.Country = "Türkiye";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

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
            request.BasketItems = basketItems;

            var threedsInitialize = ThreedsInitialize.Create(request, Options);

            this.PrintResponse<ThreedsInitialize>(threedsInitialize);

            Assert.IsNotNull(threedsInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), threedsInitialize.Locale);
            Assert.AreEqual("123456789", threedsInitialize.ConversationId);
        }

        /// <summary>
        /// Should authentication 3D-secure
        /// </summary>
        [TestMethod]
        public void ShouldAuthThreeds()
        {
            var request = new CreateThreedsPaymentRequest();

            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentId = "12345";
            request.ConversationData = "conversation data";

            var threedsPayment = ThreedsPayment.Create(request, Options);

            this.PrintResponse<ThreedsPayment>(threedsPayment);

            Assert.IsNotNull(threedsPayment.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsPayment.Status);
            Assert.AreEqual(Locale.TR.GetName(), threedsPayment.Locale);
            Assert.AreEqual("123456789", threedsPayment.ConversationId);
        }

        /// <summary>
        /// Should retrieve payment.
        /// </summary>
        [TestMethod]
        public void ShouldRetrievePayment()
        {
            var request = new RetrievePaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentId = "1";
            request.PaymentConversationId = "123456789";

            var threedsPayment = ThreedsPayment.Retrieve(request, Options);

            this.PrintResponse<ThreedsPayment>(threedsPayment);

            Assert.IsNotNull(threedsPayment.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsPayment.Status);
            Assert.AreEqual(Locale.TR.GetName(), threedsPayment.Locale);
            Assert.AreEqual("123456789", threedsPayment.ConversationId);
        }

        /// <summary>
        /// Should initialize iyzi gate 3D-secure payment with physical and virtual item.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        [TestMethod]
        public void ShouldInitializeIyziGateThreedsPaymentWithPhysicalAndVirtualItem()
        {
            var request = new CreatePaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.1";
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.CallbackUrl = "http://www.merchant.com/callbackUrl";
            request.Currency = Currency.TRY.ToString();

            // iyziGate paramters
            request.ConnectorName = "isbank";

            var paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            var buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "İstanbul";
            buyer.Country = "Türkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            var shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "İstanbul";
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            var billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "İstanbul";
            billingAddress.Country = "Türkiye";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

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
            request.BasketItems = basketItems;

            var threedsInitialize = ThreedsInitialize.Create(request, Options);

            this.PrintResponse<ThreedsInitialize>(threedsInitialize);

            Assert.IsNotNull(threedsInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), threedsInitialize.Locale);
            Assert.AreEqual("123456789", threedsInitialize.ConversationId);
        }

        /// <summary>
        /// Should initialize iyzi gate three ds payment with physical and virtual item for listing or subscription.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        [TestMethod]
        public void ShouldInitializeIyziGateThreeDSPaymentWithPhysicalAndVirtualItemForListingOrSubscription()
        {
            var request = new CreatePaymentRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.1";
            request.Installment = 3;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.LISTING.ToString();
            request.CallbackUrl = "https://www.merchant.com/callback";
            request.Currency = Currency.TRY.ToString();

            // iyziGate paramters
            request.ConnectorName = "isbank";

            var paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            var buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "İstanbul";
            buyer.Country = "Türkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            var shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "İstanbul";
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            var billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "İstanbul";
            billingAddress.Country = "Türkiye";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

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
            request.BasketItems = basketItems;

            var threedsInitialize = ThreedsInitialize.Create(request, Options);

            this.PrintResponse<ThreedsInitialize>(threedsInitialize);

            Assert.IsNotNull(threedsInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threedsInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), threedsInitialize.Locale);
            Assert.AreEqual("123456789", threedsInitialize.ConversationId);
        }
    }
}
