using System;

namespace BankDeposit_04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите срок вклада (в месяцах): ");
            int period = Convert.ToInt32(Console.ReadLine());

            int a = period;

            while (a > 0)
            {
                deposit += deposit * 0.07M;
                a--;
            }

            Console.WriteLine($"Ваша сумма вклада за {period} месяцев составляет: {deposit}");

            Console.ReadKey();
        }
    }
}
