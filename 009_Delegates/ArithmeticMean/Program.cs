using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и
 возвращает среднее арифметическое этих аргументов.
 */

namespace ArithmeticMean
{
    public delegate int Arithmetic(int x, int y, int u);

    internal class Program
    {
        private static void Main(string[] args)
        {
            int par1 = 408, par2 = 200, par3 = 292, result = 0;

            Arithmetic arithmetic = delegate (int x, int y, int u) { return (x + y + u) / 3; };

            result = arithmetic(par1, par2, par3);

            Console.WriteLine($"({par1} + {par2} + {par3}) / 3 = {result}");

            Console.ReadKey();
        }
    }
}
