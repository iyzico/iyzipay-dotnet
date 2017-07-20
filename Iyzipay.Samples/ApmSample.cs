using Iyzipay.Model;
using Iyzipay.Request;
using NUnit.Framework;
using System.Collections.Generic;

namespace Iyzipay.Samples
{
    public class ApmSample : Sample
    {
        [Test]
        public void Should_Initialize_Apm_Payment()
        {
            CreateApmInitializeRequest request = new CreateApmInitializeRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.PaidPrice = "1.2";
            request.Currency = Currency.EUR.ToString();
            request.CountryCode = "DE";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.AccountHolderName = "success";
            request.MerchantCallbackUrl = "https://www.merchant.com/callback";
            request.MerchantErrorUrl= "https://www.merchant.com/error";
            request.MerchantNotificationUrl= "https://www.merchant.com/notification";
            request.ApmType = ApmType.SOFORT.ToString();

            Buyer buyer = new Buyer();
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
            buyer.City = "Istanbul";
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

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
            request.BasketItems = basketItems;

            Apm apmInitialize = Apm.Create(request, options);

            PrintResponse<Apm>(apmInitialize);

            Assert.AreEqual(Status.SUCCESS.ToString(), apmInitialize.Status);
            Assert.AreEqual(Locale.TR.ToString(), apmInitialize.Locale);
            Assert.AreEqual("123456789", apmInitialize.ConversationId);
            Assert.IsNotNull(apmInitialize.SystemTime);
            Assert.IsNull(apmInitialize.ErrorCode);
            Assert.IsNull(apmInitialize.ErrorMessage);
            Assert.IsNull(apmInitialize.ErrorGroup);
        }

        [Test]
        public void Should_Retrieve_Apm_Result()
        {
            RetrieveApmRequest request = new RetrieveApmRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.PaymentId = "1";

            Apm retrieve = Apm.Retrieve(request, options);

            PrintResponse<Apm>(retrieve);

            Assert.AreEqual(Status.SUCCESS.ToString(), retrieve.Status);
            Assert.AreEqual(Locale.TR.ToString(), retrieve.Locale);
            Assert.AreEqual("123456789", retrieve.ConversationId);
        }
    }
}
