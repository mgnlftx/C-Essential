namespace Notebooks
{
    internal struct Notebook
    {
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public decimal Price { get; set; }

        public Notebook(string model, string manufacturer, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Блокнот {Model}, изготовитель {Manufacturer}, цена {Price}";
        }

        //public void Info()
        //{
        //    Console.WriteLine($"Блокнот {Model}, изготовитель {Manufacturer}, цена {Price}");
        //}
    }
}
