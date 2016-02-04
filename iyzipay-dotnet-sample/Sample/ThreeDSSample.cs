using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;
using System.Collections.Generic;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ThreeDSSample : Sample
    {
        [TestMethod]
        public void Should_Create_Market_Place_Physical_And_Virtual_Product_With_Three_Ds_Payment()
        {
            CreateThreeDSInitializeRequest request = new CreateThreeDSInitializeRequest();

            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CallbackUrl = "http://localhost:8080/callbackUrl";
            request.Price = "1";
            request.PaidPrice = "1.1";
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "Sabri Onur";
            buyer.Surname = "Tüzün";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy";
            buyer.Ip = "85.34.78.112";
            buyer.City = "İstanbul";
            buyer.Country = "Türkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Hakan Erdoğan";
            shippingAddress.City = "İstanbul";
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = "19 Mayıs Mah. İnönü Cad. No:45 Kozyatağı";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Hakan Erdoğan";
            billingAddress.City = "İstanbul";
            billingAddress.Country = "Türkiye";
            billingAddress.Description = "19 Mayıs Mah. İnönü Cad. No:45 Kozyatağı";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem1 = new BasketItem();
            basketItem1.Id = "BI101";
            basketItem1.Name = "ABC Marka Kolye";
            basketItem1.Category1 = "Giyim";
            basketItem1.Category2 = "Aksesuar";
            basketItem1.ItemType = BasketItemType.PHYSICAL.ToString();
            basketItem1.Price = "0.3";
            basketItem1.SubMerchantKey = "subMerchantKey";
            basketItem1.SubMerchantPrice = "0.27";
            basketItems.Add(basketItem1);

            BasketItem basketItem2 = new BasketItem();
            basketItem2.Id = "BI102";
            basketItem2.Name = "XYZ Oyun Kodu";
            basketItem2.Category1 = "Oyun";
            basketItem2.Category2 = "Online Oyun Kodları";
            basketItem2.ItemType = BasketItemType.VIRTUAL.ToString();
            basketItem2.Price = "0.5";
            basketItem2.SubMerchantKey = "subMerchantKey";
            basketItem2.SubMerchantPrice = "0.42";
            basketItems.Add(basketItem2);

            BasketItem basketItem3 = new BasketItem();
            basketItem3.Id = "BI103";
            basketItem3.Name = "EDC Marka Usb";
            basketItem3.Category1 = "Elektronik";
            basketItem3.Category2 = "Usb / Cable";
            basketItem3.ItemType = BasketItemType.PHYSICAL.ToString();
            basketItem3.Price = "0.2";
            basketItem3.SubMerchantKey = "subMerchantKey";
            basketItem3.SubMerchantPrice = "0.18";
            basketItems.Add(basketItem3);
            request.BasketItems = basketItems;

            ThreeDSInitialize threeDSInitialize = ThreeDSInitialize.Create(request, options);

            PrintResponse<ThreeDSInitialize>(threeDSInitialize);

            Assert.IsNotNull(threeDSInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threeDSInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), threeDSInitialize.Locale);
            Assert.AreEqual("123456789", threeDSInitialize.ConversationId);
        }

        [TestMethod]
        public void Should_Create_Physical_And_Virtual_Listing_Or_Subscription_With_Threeds_Payment()
        {
            CreateThreeDSInitializeRequest request = new CreateThreeDSInitializeRequest();

            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.CallbackUrl = "https://www.merchant.com/callback";
            request.Price = "1";
            request.PaidPrice = "1.1";
            request.Installment = 3;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.LISTING.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "****************";
            paymentCard.ExpireMonth = "**";
            paymentCard.ExpireYear = "****";
            paymentCard.Cvc = "***";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "Sabri Onur";
            buyer.Surname = "Tüzün";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe İş Merkezi Merdivenköy Mah. Bora Sok. No:1 Kat:19 Bağımsız 70/73 Göztepe Kadıköy";
            buyer.Ip = "85.34.78.112";
            buyer.City = "İstanbul";
            buyer.Country = "Türkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Hakan Erdoğan";
            shippingAddress.City = "İstanbul";
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = "19 Mayıs Mah. İnönü Cad. No:45 Kozyatağı";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Hakan Erdoğan";
            billingAddress.City = "İstanbul";
            billingAddress.Country = "Türkiye";
            billingAddress.Description = "19 Mayıs Mah. İnönü Cad. No:45 Kozyatağı";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem1 = new BasketItem();
            basketItem1.Id = "BI101";
            basketItem1.Name = "Dükkan listelemesi ve katalog";
            basketItem1.Category1 = "Listeleme";
            basketItem1.Category2 = "Dükkan";
            basketItem1.ItemType = BasketItemType.PHYSICAL.ToString();
            basketItem1.Price = "0.3";
            basketItems.Add(basketItem1);

            BasketItem basketItem2 = new BasketItem();
            basketItem2.Id = "BI102";
            basketItem2.Name = "Listeleme hizmeti";
            basketItem2.Category1 = "Listeleme";
            basketItem2.Category2 = "Listeleme";
            basketItem2.ItemType = BasketItemType.VIRTUAL.ToString();
            basketItem2.Price = "0.5";
            basketItems.Add(basketItem2);

            BasketItem basketItem3 = new BasketItem();
            basketItem3.Id = "BI103";
            basketItem3.Name = "Servis hizmeti";
            basketItem3.Category1 = "Listeleme";
            basketItem3.Category2 = "Servis";
            basketItem3.ItemType = BasketItemType.VIRTUAL.ToString();
            basketItem3.Price = "0.2";
            basketItems.Add(basketItem3);
            request.BasketItems = basketItems;

            ThreeDSInitialize threeDSInitialize = ThreeDSInitialize.Create(request, options);

            PrintResponse<ThreeDSInitialize>(threeDSInitialize);

            Assert.IsNotNull(threeDSInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threeDSInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), threeDSInitialize.Locale);
            Assert.AreEqual("123456789", threeDSInitialize.ConversationId);
        }

        [TestMethod]
        public void Should_Auth_Threeds()
        {
            CreateThreeDSAuthRequest request = new CreateThreeDSAuthRequest();

            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.PaymentId = "12345";
            request.ConversationData = "conversation data";

            ThreeDSAuth threeDSAuth = ThreeDSAuth.Create(request, options);

            PrintResponse<ThreeDSAuth>(threeDSAuth);

            Assert.IsNotNull(threeDSAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), threeDSAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), threeDSAuth.Locale);
            Assert.AreEqual("123456789", threeDSAuth.ConversationId);
        }
    }
}
