using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс с именем Rectangle.
 В теле класса создать два поля, описывающие длины сторон double side1, side2.
 Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
 поля side1 и side2 инициализируются значениями аргументов.
 Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
 прямоугольника - double PerimeterCalculator().
 Создать два свойства double Area и double Perimeter с одним методом доступа get.
 Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
 на экран периметр и площадь.
 */

namespace Task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника");
            string a = Console.ReadLine();
            double side1 = Convert.ToDouble(a);

            Console.WriteLine("Введите вторую сторону прямоугольника");
            string c = Console.ReadLine();
            double side2 = Convert.ToDouble(c);

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площадь = {rectangle.Area}");
            Console.WriteLine($"Периметр = {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
