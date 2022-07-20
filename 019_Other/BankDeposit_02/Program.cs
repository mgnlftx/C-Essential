using System;

namespace BankDeposit_02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            double deposit = Convert.ToDouble(Console.ReadLine());
            double percent = 0;

            if (deposit < 100)
            {
                percent = 0.05;
            }
            else if (100 <= deposit && deposit <= 200)
            {
                percent = 0.07;
            }
            else
            {
                percent = 0.1;
            }

            deposit += deposit * percent + 15;

            Console.WriteLine($"Ваша сумма вклада с начисленными процентами состовляет: {deposit}");

            Console.ReadKey();
        }
    }
}
