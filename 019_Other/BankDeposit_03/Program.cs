using System;

namespace BankDeposit_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите срок вклада (в месяцах): ");
            int period = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= period; i++)
            {
                deposit += deposit * 0.07M;
            }

            Console.WriteLine($"Ваша сумма вклада за {period} месяцев составляет: {deposit}");

            Console.ReadKey();
        }
    }
}
