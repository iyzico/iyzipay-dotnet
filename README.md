# iyzipay-dotnet

You can sign up for an iyzico account at https://iyzico.com

# Requirements

.NET Framewrok 4.5.2 or newer

# Installation

Fro now you'll need to install following libraries:
* Newtonsoft.Json 8.0.2 from http://www.newtonsoft.com/json#

# Usage

```.NET
public static void Main(string[] args)
{
    CreatePaymentRequest request = new CreatePaymentRequest();
    request.Locale = Locale.TR.GetName();
    request.ConversationId = "123456789";
    request.Price = "1";
    request.PaidPrice = "1.1";
    request.Installment = 1;
    request.BasketId = "B67832";
    request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
    request.PaymentChannel = PaymentChannel.WEB.ToString();

    PaymentCard paymentCard = new PaymentCard();
    paymentCard.CardHolderName = "John Doe";
    paymentCard.CardNumber = "5528790000000008";
    paymentCard.RegisterCard = 0;
    paymentCard.ExpireMonth = "11";
    paymentCard.ExpireYear = "2017";
    paymentCard.Cvc = "123";
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

    PaymentAuth paymentAuth = PaymentAuth.Create(request, options);
}
```
See other samples under iyzipay-dotnet-sample/Sample/ package.

# Testing

You can run particular sample by passing your credential info to "iyzipay-dotnet-sample/Sample/Sample.cs"
