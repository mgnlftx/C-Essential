namespace Order
{
    internal class Invoice
    {
        private string article;
        private int quantity;

        public int Account { get; }

        public string Customer { get; }

        public string Provider { get; }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public double CalculateOrderCost(double price, int quantity, bool withNDS)
        {
            this.quantity = quantity;

            double cost = price * quantity;

            cost *= withNDS ? 1.2 : 1;

            return cost;
        }
    }
}
