using System;

namespace Inventory
{
    internal class Article
    {
        public string ProductName { get; set; }

        public string ShopName { get; set; }

        public decimal Price { get; set; }

        public Article(decimal price, string productName, string shopName)
        {
            Price = price;
            ProductName = productName;
            ShopName = shopName;
        }

        public void Show()
        {
            Console.WriteLine(ProductName);
            Console.WriteLine(ShopName);
            Console.WriteLine(Price);
        }
    }
}
