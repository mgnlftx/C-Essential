using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
 Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
 */

namespace Arrays_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(50);
            }

            int max = array[0];
            int min = array[0];
            int sum = 0;
            double average;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];

                if (array[i] < min)
                    min = array[i];

                if (array[i] % 2 == 1)
                    Console.WriteLine(array[i]);

                sum += array[i];
            }

            average = sum / size;

            Console.WriteLine($"Наибольшее значение массива {max}");

            Console.WriteLine($"Наименьшее значение массива {min} ");

            Console.WriteLine($"Сумма всех элементов {sum}");

            Console.WriteLine($"Среднее арифметическое {average}");
        }
    }
}
