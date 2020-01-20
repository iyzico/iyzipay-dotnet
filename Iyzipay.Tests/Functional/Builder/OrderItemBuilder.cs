using System.Collections.Generic;
using Iyzipay.Model;

namespace Iyzipay.Tests.Functional.Builder
{
    public sealed class OrderItemBuilder
    {
        private string _id = "BI101";
        private string _name = "Binocular";
        private string _category1 = "Collectibles";
        private string _category2 = "Accessories";
        private string _itemType = OrderItemType.PHYSICAL.ToString();
        private string _itemUrl = "www.merchant.biz/itemUrl";
        private string _itemDescription = "Item Description";
        private string _price;

        private OrderItemBuilder()
        {
        }
        
        public static OrderItemBuilder Create()
        {
            return new OrderItemBuilder();
        }
        
        public OrderItemBuilder Id(string id)
        {
            _id = id;
            return this;
        }

        public OrderItemBuilder Name(string name)
        {
            _name = name;
            return this;
        }

        public OrderItemBuilder Category1(string category1)
        {
            _category1 = category1;
            return this;
        }

        public OrderItemBuilder Category2(string category2)
        {
            _category2 = category2;
            return this;
        }

        public OrderItemBuilder ItemType(string itemType)
        {
            _itemType = itemType;
            return this;
        }

        public OrderItemBuilder ItemUrl(string itemUrl)
        {
            _itemUrl = itemUrl;
            return this;
        }

        public OrderItemBuilder ItemDescription(string itemDescription)
        {
            _itemDescription = itemDescription;
            return this;
        }
        

        public OrderItemBuilder Price(string price)
        {
            _price = price;
            return this;
        }
        
        public OrderItem Build()
        {
            OrderItem orderItem = new OrderItem();
            orderItem.Id = _id;
            orderItem.Name = _name;
            orderItem.Category1 = _category1;
            orderItem.Category2 = _category2;
            orderItem.ItemType = _itemType;
            orderItem.ItemUrl = _itemUrl;
            orderItem.ItemDescription = _itemDescription;
            orderItem.Price = _price;
                
            return orderItem;
        }
        
        public List<OrderItem> BuildOrderItems()
        {
            List<OrderItem> orderItems = new List<OrderItem>
            {
                    Create().Price("0.3").ItemDescription("item description").Category2(null).Build(),
                    Create().Price("0.5").ItemDescription("item description").Build(),
                    Create().Price("0.2").ItemDescription("item description").Build()
            };
            return orderItems;
        }
        
    }
}