using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
 вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два
 аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку
 деления на ноль.
 Написать программу, которая будет выполнять арифметические действия, указанные пользователем.
 */

namespace ArithmeticOperations_03
{
    public delegate int Arithmetic(int x, int y);

    internal class Program
    {
        private static void Main(string[] args)
        {
            Arithmetic sum = delegate (int x, int y)
            {
                return x + y;
            };

            Arithmetic subtraction = delegate (int x, int y)
            {
                return x - y;
            };

            Arithmetic multiply = delegate (int x, int y)
            {
                return x * y;
            };

            Arithmetic div = delegate (int x, int y)
            {
                if (y != 0)
                {
                    return x * y;
                }
                else
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return 0;
                }
            };

            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение 4.Деление: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (operation)
            {
                case 1:
                    result = sum(x, y);
                    Console.WriteLine($"Ответ:{result}");
                    break;

                case 2:
                    result = subtraction(x, y);
                    Console.WriteLine($"Ответ:{result}");
                    break;

                case 3:
                    result = multiply(x, y);
                    Console.WriteLine($"Ответ:{result}");
                    break;

                case 4:
                    result = div(x, y);
                    Console.WriteLine($"Ответ:{result}");
                    break;

                default:
                    Console.WriteLine("Неопределенная операция");
                    break;
            }
        }
    }
}
