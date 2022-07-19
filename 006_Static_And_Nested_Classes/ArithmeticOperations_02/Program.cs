using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
 Написать программу, которая выводит на экран основные арифметические операции.
 */

namespace ArithmeticOperations_02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int o = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('=', 15));

            Calculator.Sum(o, k);
            Calculator.Difference(o, k);
            Calculator.Product(o, k);
            Calculator.Quotient(o, k);
        }
    }
}
