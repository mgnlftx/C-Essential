using System;
using Transport.Classes;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс Vehicle.
 В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
 Создайте 3 производных класса Plane, Саг и Ship.
 Для класса Plane должна быть определена высота и количество пассажиров.
 Для класса Ship — количество пассажиров и порт приписки.
 Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
 */

namespace Transport
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car car = new Car();

            car.Coordinates = "55.752675, 37.621867";
            car.Price = 30000;
            car.Speed = 90;
            car.YearOrIssue = 2008;

            Ship ship = new();

            ship.Coordinates = "55.938475, 37.871867";
            ship.Price = 1000000;
            ship.Speed = 120;
            ship.YearOrIssue = 1969;
            ship.Passengers = 33;
            ship.HomePort = "Мурманск";

            Plane plane = new();

            plane.Coordinates = "55.767525, 37.948362";
            plane.Price = 2000000;
            plane.Speed = 900;
            plane.YearOrIssue = 2011;
            plane.Height = 40;
            plane.Passengers = 99;

            car.GetInfo();

            Console.WriteLine(new string('-', 30));

            ship.GetInfo();

            Console.WriteLine(new string('-', 30));

            plane.GetInfo();

            Console.ReadKey();
        }
    }
}
