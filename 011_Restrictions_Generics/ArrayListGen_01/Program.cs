using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его
 экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.
 */

namespace ArrayListGen_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyArrayList my = new MyArrayList();

            my.Add(5);
            my.Add("Hello");
            my.Add('d');
            my.Add(5.78);

            Console.WriteLine("Массив: ");
            Console.WriteLine(my.ToString());
        }
    }
}
