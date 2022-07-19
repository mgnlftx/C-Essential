using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
 Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
 для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
 метод GetArray().
 */

namespace ListGen_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива: ");
            int u = Convert.ToInt32(Console.ReadLine());

            var list = new MyList<int>(u);

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(x, t.Next(100));
            }

            Console.WriteLine("Массив");
            int[] f = list.GetArray();  // Использование расширяющего метода.

            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("{0} ", f[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Длинна массива: {0}", list.Lenght);
        }
    }
}
