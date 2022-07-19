namespace CalculatorException
{
    internal class Calculator
    {
        public void Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        public void Difference(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

        public void Product(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }

        public void Quotient(int x, int y)
        {
            try
            {
                Console.WriteLine(x / y);
            }
            catch
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
        }
    }
}
