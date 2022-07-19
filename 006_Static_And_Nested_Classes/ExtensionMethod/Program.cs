using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы
 массива по возрастанию.
 */

namespace ExtensionMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 1, 5, 4, 2, 3, 9, 7, 6, 8 };

            array.SortUp();

            foreach (int a in array)
                Console.Write(a + " ");
        }
    }
}
