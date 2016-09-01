using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Model;
using Iyzipay.Request;
using System.Collections.Generic;

namespace IyzipaySample.Sample
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
            request.ShippingAddress = NewShippingAddress();
            request.BillingAddress = NewBillingAddress();
            request.BasketItems = NewBasketItems();
            request.CallbackUrl = "https://www.merchant.com/callback";
            request.Currency = Currency.TRY.ToString();
            request.EnabledInstallments = NewEnabledInstallments();

            CheckoutFormInitialize checkoutFormInitialize = CheckoutFormInitialize.Create(request, options);

            PrintResponse<CheckoutFormInitialize>(checkoutFormInitialize);

            Assert.IsNotNull(checkoutFormInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), checkoutFormInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), checkoutFormInitialize.Locale);
            Assert.AreEqual("123456789", checkoutFormInitialize.ConversationId);
        }

        [TestMethod]
        public void Should_Retrieve_Checkout_Form_Result()
        {
            RetrieveCheckoutFormRequest request = new RetrieveCheckoutFormRequest();
            request.ConversationId = "123456789";
            request.Token = "token";

            CheckoutForm checkoutForm = CheckoutForm.Retrieve(request, options);

            PrintResponse<CheckoutForm>(checkoutForm);

            Assert.IsNotNull(checkoutForm.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), checkoutForm.Status);
            Assert.AreEqual("123456789", checkoutForm.ConversationId);
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
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.City = "Istanbul";
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34732";
            buyer.Ip = "85.34.78.112";
            return buyer;
        }

        private Address NewShippingAddress()
        {
            Address address = new Address();
            address.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            address.ZipCode = "34742";
            address.ContactName = "Jane Doe";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private Address NewBillingAddress()
        {
            Address address = new Address();
            address.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            address.ZipCode = "34742";
            address.ContactName = "Jane Doe";
            address.City = "Istanbul";
            address.Country = "Turkiye";
            return address;
        }

        private List<BasketItem> NewBasketItems()
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
        private List<int> NewEnabledInstallments()
        {
            List<int> enabledInstallments = new List<int>();
            enabledInstallments.Add(2);
            enabledInstallments.Add(3);
            enabledInstallments.Add(6);
            enabledInstallments.Add(9);
            return enabledInstallments;
        }
    }
}
