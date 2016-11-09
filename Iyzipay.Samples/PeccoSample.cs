using Iyzipay.Request;
using Iyzipay.Model;
using System.Collections.Generic;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class PeccoSample : Sample
    {
        [Test]
        public void Should_Initialize_Pecco()
        {
            CreatePeccoInitializeRequest request = new CreatePeccoInitializeRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = "100000";
            request.PaidPrice = "120000";
            request.Currency = Currency.IRR.ToString();
            request.BasketId = "B67832";
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.CallbackUrl = "https://www.merchant.com/callback";
            
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
            firstBasketItem.Price = "30000";
            basketItems.Add(firstBasketItem);

            BasketItem secondBasketItem = new BasketItem();
            secondBasketItem.Id = "BI102";
            secondBasketItem.Name = "Game code";
            secondBasketItem.Category1 = "Game";
            secondBasketItem.Category2 = "Online Game Items";
            secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
            secondBasketItem.Price = "50000";
            basketItems.Add(secondBasketItem);

            BasketItem thirdBasketItem = new BasketItem();
            thirdBasketItem.Id = "BI103";
            thirdBasketItem.Name = "Usb";
            thirdBasketItem.Category1 = "Electronics";
            thirdBasketItem.Category2 = "Usb / Cable";
            thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            thirdBasketItem.Price = "20000";
            basketItems.Add(thirdBasketItem);
            request.BasketItems = basketItems;

            PeccoInitialize peccoInitialize = PeccoInitialize.Create(request, options);

            PrintResponse<PeccoInitialize>(peccoInitialize);

            Assert.AreEqual(Status.SUCCESS.ToString(), peccoInitialize.Status);
            Assert.AreEqual(Locale.TR.ToString(), peccoInitialize.Locale);
            Assert.AreEqual("123456789", peccoInitialize.ConversationId);
            Assert.IsNotNull(peccoInitialize.SystemTime);
            Assert.IsNull(peccoInitialize.ErrorCode);
            Assert.IsNull(peccoInitialize.ErrorMessage);
            Assert.IsNull(peccoInitialize.ErrorGroup);
            Assert.IsNotNull(peccoInitialize.HtmlContent);
        }

        [Test]
        public void Should_Create_Pecco_Payment()
        {
            CreatePeccoPaymentRequest request = new CreatePeccoPaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Token = "token";

            PeccoPayment peccoPayment = PeccoPayment.Create(request, options);

            PrintResponse<PeccoPayment>(peccoPayment);

            Assert.AreEqual(Status.SUCCESS.ToString(), peccoPayment.Status);
            Assert.AreEqual(Locale.TR.ToString(), peccoPayment.Locale);
            Assert.AreEqual("123456789", peccoPayment.ConversationId);
            Assert.IsNotNull(peccoPayment.SystemTime);
            Assert.IsNull(peccoPayment.ErrorCode);
            Assert.IsNull(peccoPayment.ErrorMessage);
            Assert.IsNull(peccoPayment.ErrorGroup);
        }
    }
}
