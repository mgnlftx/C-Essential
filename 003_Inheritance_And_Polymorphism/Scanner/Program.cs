using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создайте класс Printer.
 В теле класса создайте метод void Print(string value), который выводит на экран значение
 аргумента.
 Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
 соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
 выводились разными цветами.
 Обязательно используйте приведение типов.
 */

namespace Scanner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Printer printer = new Printer();

            Printer printer1 = new Printer_2();
            Printer printer2 = new Printer_3();

            string hello = "hello";
            printer.Print(hello);
            printer1.Print(hello);
            printer2.Print(hello);

            Console.ReadKey();
        }
    }
}
