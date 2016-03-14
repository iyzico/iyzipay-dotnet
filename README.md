You can sign up for an iyzico account at https://iyzico.com

# Requirements

.NET Framework 4.5.2 or newer

# Installation

For now you'll need to install following libraries:

* To install Iyzipay, run the following command in the Package Manager Console
```
      Install-Package Iyzipay
```
 Or you can download the latest .dll from:  https://github.com/iyzico/iyzipay-dotnet/releases/latest
 
* Newtonsoft.Json 8.0.2 from http://www.newtonsoft.com/json#


# Usage

```.NET
public static void Main(string[] args)
{
	Options options = new Options();
    options.ApiKey = "your api key";
    options.SecretKey = "your secret key";
	options.BaseUrl = "https://stg.iyzipay.com";
			
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
	buyer.Name = "John";
	buyer.Surname = "Doe";
	buyer.GsmNumber = "+905350000000";
	buyer.Email = "email@email.com";
	buyer.IdentityNumber = "74300864791";
	buyer.LastLoginDate = "2015-10-05 12:43:35";
	buyer.RegistrationDate = "2013-04-21 15:12:09";
	buyer.RegistrationAddress = "Address";
	buyer.Ip = "85.34.78.112";
	buyer.City = "İstanbul";
	buyer.Country = "Türkiye";
	buyer.ZipCode = "34732";
	request.Buyer = buyer;

	Address shippingAddress = new Address();
	shippingAddress.ContactName = "Jane Doe";
	shippingAddress.City = "İstanbul";
	shippingAddress.Country = "Türkiye";
	shippingAddress.Description = "Address";
	shippingAddress.ZipCode = "34742";
	request.ShippingAddress = shippingAddress;

	Address billingAddress = new Address();
	billingAddress.ContactName = "Jane Doe";
	billingAddress.City = "İstanbul";
	billingAddress.Country = "Türkiye";
	billingAddress.Description = "Address";
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

	PaymentAuth paymentAuth = PaymentAuth.Create(request, options);
}
```
See other samples under iyzipay-dotnet-sample/Sample/ package.

# Testing

You can run particular sample by passing your credential info to "iyzipay-dotnet-sample/Sample/Sample.cs"
