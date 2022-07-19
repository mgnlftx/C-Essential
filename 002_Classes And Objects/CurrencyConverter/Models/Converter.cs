namespace CurrencyConverter
{
    internal class Converter
    {
        public double USD { get; }

        public double EUR { get; }

        public double RUB { get; }

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ToUSD(double value)
        {
            return value * USD;
        }

        public double ToEUR(double value)
        {
            return value * EUR;
        }

        public double ToRUB(double value)
        {
            return value * RUB;
        }

        public double FromUSD(double value)
        {
            return value / USD;
        }

        public double FromEUR(double value)
        {
            return value / EUR;
        }

        public double FromRUB(double value)
        {
            return value / RUB;
        }
    }
}
