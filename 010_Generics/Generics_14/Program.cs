using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте класс MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
 использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
 Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
 добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
 свойство только для чтения для получения общего количества пар элементов.
 */

namespace Generics_14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность словаря: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var dictionary = new MyDictionary<string, string>(n);

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, "table", "стол");
            }

            Console.WriteLine(new string('=', 15));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Lenght);
        }
    }
}
