using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
 экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
 взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
 получения значения элемента по указанному индексу и свойство только для чтения для получения
 общего количества элементов.
 */

namespace ListGen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива: ");
            string size = Console.ReadLine();
            int b = string.IsNullOrEmpty(size) ? 0 : Convert.ToInt32(size);

            var list = new MyList<int>();

            var r = new Random();
            for (int c = 0; c < b; c++)
            {
                list.Add(r.Next(100));
            }

            Console.WriteLine("Массив элементов: ");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(new string('=', 25));

            Console.WriteLine("Введите значение для поиска: ");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("Введённое значение содержится в массиве");
            }
            else
            {
                Console.WriteLine("Значение не найдено.");
            }
        }
    }
}
