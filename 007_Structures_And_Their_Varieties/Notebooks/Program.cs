using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте структуру с именем - Notebook.
 Поля структуры: модель, производитель, цена.
 В структуре должен быть реализован конструктор для инициализации полей и метод для вывода
 содержимого полей на экран.
 */

namespace Notebooks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Notebook notebook = new Notebook { Model = "Nature", Manufacturer = "Pipopu", Price = 300 };
            Console.WriteLine(notebook.ToString());

            //notebook.Model = "Nature";
            //notebook.Manufacturer = "Pipopu";
            //notebook.Price = 300;

            //notebook.Info();

            Console.ReadKey();
        }
    }
}
