using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте статический класс с методом void Print (string stroka, int color), который выводит на
 экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных
 пользователю. Ввод строки и выбор цвета предоставьте пользователю.
 */

namespace EnumsColors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("Выберите цвет: 1 - Green, 2 - Blue, 3 - Red, 4 - Yellow, 5 - Cyan, 6 - Magenta");
            int color = Convert.ToInt32(Console.ReadLine());

            Printer.Print(color, text);

            Console.ReadKey();
        }
    }
}
