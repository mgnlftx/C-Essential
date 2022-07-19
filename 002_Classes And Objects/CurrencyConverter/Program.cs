using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс Converter.
 В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
 и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
 Converter(double usd, double eur, double rub).
 Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
 также программа должна производить конвертацию из указанных валют в гривну.
 */

namespace CurrencyConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Converter converter = new Converter(0.034, 0.032, 2.81);

            Console.WriteLine("Введите гривны");
            double salaryUa = Convert.ToDouble(Console.ReadLine());

            double salaryUSD = converter.ToUSD(salaryUa);
            Console.WriteLine($"При переводе {salaryUa} гривна в USD получилось {salaryUSD}");
            Console.WriteLine(converter.FromUSD(salaryUSD));

            double salaryEUR = converter.ToEUR(salaryUa);
            Console.WriteLine($"При переводе {salaryUa} гривна в EUR получилось {salaryEUR}");
            Console.WriteLine(converter.FromEUR(salaryEUR));

            double salaryRUB = converter.ToRUB(salaryUa);
            Console.WriteLine($"При переводе {salaryUa} гривна в RUB получилось {salaryRUB}");
            Console.WriteLine(converter.FromRUB(salaryRUB));

            Console.ReadKey();
        }
    }
}
