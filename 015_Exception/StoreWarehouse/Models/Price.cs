namespace StoreWarehouse
{
    internal struct Price
    {
        public string ProductName { get; set; }

        public string ShopName { get; set; }

        public decimal Priced { get; set; }

        //Надо или лишнее?
        public Price(string pName, string sName, decimal price)
        {
            ProductName = pName;
            ShopName = sName;
            Priced = price;
        }

        public override string ToString()
        {
            return (string.Format("Название товара: {0} ,\n" +
                                 "Название магазина: {1},\n" +
                                 "Стоимость товара в рублях: {2} ", ProductName, ShopName, Priced));
        }
    }
}
