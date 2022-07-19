using System;

namespace ArithmeticOperations_02
{
    internal static class Calculator
    {
        public static void Sum(int o, int k)
        {
            int result = o + k;
            Console.WriteLine($"{o} + {k} = {result}");
        }

        public static void Difference(int o, int k)
        {
            int result = o - k;
            Console.WriteLine($"{o} - {k} = {result}");
        }

        public static void Product(int o, int k)
        {
            int result = o * k;
            Console.WriteLine($"{o} * {k} = {result}");
        }

        public static void Quotient(int o, int k)
        {
            if (k != 0)
            {
                int result = o / k;
                Console.WriteLine($"{o} / {k} = {result}");
            }
            else
                Console.WriteLine("На ноль делить нельзя!");
        }
    }
}
