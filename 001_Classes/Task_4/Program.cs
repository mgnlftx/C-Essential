using System;
using Task_4.Classes;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать классы Point и Figure.
 Класс Point должен содержать два целочисленных поля и одно строковое поле.
 Создать три свойства с одним методом доступа get.
 Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
 аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
 аргументов типа Point.
 Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
 стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
 многоугольника.
 Написать программу, которая выводит на экран название и периметр многоугольника.
 */

namespace Task_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Point point1 = new Point(0, 0, "a");

            Point point2 = new Point(1, 1, "b");

            Point point3 = new Point(2, 2, "c");

            Figure figure = new Figure(point1, point2, point3);

            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
