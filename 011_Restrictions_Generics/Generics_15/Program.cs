using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте класс Dictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
 использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен
 System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром,
 должен включать метод добавления пар элементов, индексатор для получения значения элемента по
 указанному индексу и свойство только для чтения для получения общего количества пар элементов.
 */

namespace Generics_15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Словарь: ");

            var dic = new Dictionary<string, string>();

            dic.AddToDictionary("table", "стол");
            dic.AddToDictionary("apple", "яблоко");
            dic.AddToDictionary("sun", "солнце");
            dic.AddToDictionary("pencil", "карандаш");
            dic.AddToDictionary("cup", "чашка");
            dic.AddToDictionary("tea", "чай");

            Console.WriteLine(dic.ToString());
            Console.WriteLine();
            Console.WriteLine("В словаре {0} записей", dic.Lenght);

            Console.WriteLine(new string('=', 25));

            Console.WriteLine("Введите номер записи в словаре: ");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Вы не ввели номер записи в словаре");
            else
            {
                int number = Convert.ToInt32(str);
                Console.WriteLine(dic[number - 1]);
            }

            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dic[p]);
        }
    }
}
