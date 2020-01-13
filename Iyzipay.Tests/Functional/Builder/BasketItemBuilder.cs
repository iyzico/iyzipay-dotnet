using System.Collections.Generic;
using Iyzipay.Model;

namespace Iyzipay.Tests.Functional.Builder
{
    public sealed class BasketItemBuilder
    {
        private string _id = "BI101";
        private string _name = "Binocular";
        private string _category1 = "Collectibles";
        private string _category2 = "Accessories";
        private string _itemType = BasketItemType.PHYSICAL.ToString();
        private string _subMerchantKey;
        private string _subMerchantPrice;
        private string _price;

        private BasketItemBuilder()
        {
        }

        public static BasketItemBuilder Create()
        {
            return new BasketItemBuilder();
        }

        public BasketItemBuilder Id(string id)
        {
            _id = id;
            return this;
        }

        public BasketItemBuilder Price(string price)
        {
            _price = price;
            return this;
        }

        public BasketItemBuilder Name(string name)
        {
            _name = name;
            return this;
        }

        public BasketItemBuilder Category1(string category1)
        {
            _category1 = category1;
            return this;
        }

        public BasketItemBuilder Category2(string category2)
        {
            _category2 = category2;
            return this;
        }

        public BasketItemBuilder ItemType(string itemType)
        {
            _itemType = itemType;
            return this;
        }

        public BasketItemBuilder SubMerchantKey(string subMerchantKey)
        {
            _subMerchantKey = subMerchantKey;
            return this;
        }

        public BasketItemBuilder SubMerchantPrice(string subMerchantPrice)
        {
            _subMerchantPrice = subMerchantPrice;
            return this;
        }

        public BasketItem Build()
        {
            BasketItem basketItem = new BasketItem();
            basketItem.Id = _id;
            basketItem.Price = _price;
            basketItem.Name = _name;
            basketItem.Category1 = _category1;
            basketItem.Category2 = _category2;
            basketItem.ItemType = _itemType;
            basketItem.SubMerchantKey = _subMerchantKey;
            basketItem.SubMerchantPrice = _subMerchantPrice;
            return basketItem;
        }

        public List<BasketItem> BuildDefaultBasketItems()
        {
            List<BasketItem> basketItems = new List<BasketItem>
            {
                Create().Price("0.3").Category2(null).Build(),
                Create().Price("0.5").Build(),
                Create().Price("0.2").Build()
            };
            return basketItems;
        }

        public List<BasketItem> BuildBasketItemsWithSubMerchantKey(string subMerchantKey)
        {
            List<BasketItem> basketItems = new List<BasketItem>
            {
                Create()
                    .Price("0.3")
                    .Category2(null).SubMerchantKey(subMerchantKey)
                    .SubMerchantPrice("0.27")
                    .Build(),
                Create().Price("0.5")
                    .Category2(null).SubMerchantKey(subMerchantKey)
                    .SubMerchantPrice("0.42")
                    .Build(),
                Create().Price("0.2")
                    .Category2(null).SubMerchantKey(subMerchantKey)
                    .SubMerchantPrice("0.18")
                    .Build()
            };
            return basketItems;
        }
    }
}
