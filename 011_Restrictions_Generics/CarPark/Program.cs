using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
 использования его экземпляра для создания парка машин. Минимально требуемый интерфейс
 взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и
 года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство
 только для чтения для получения общего количества элементов.
 Создайте метод удаления всех машин автопарка.
 */

namespace CarPark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Парк машин: ");
            var park = new CarCollection<string>();

            park.AddCar("Ford", new DateTime(2005, 5, 3));
            park.AddCar("Mercedes", new DateTime(1998, 8, 9));
            park.AddCar("Toyota", new DateTime(1970, 9, 1));
            park.AddCar("Dodge", new DateTime(2010, 2, 20));
            park.AddCar("Cadillac", new DateTime(2008, 5, 4));

            Console.WriteLine(park.ToString());

            Console.WriteLine("В парке находится: {0} машин", park.Lenght);

            Console.WriteLine("Введите номер интересующей вас машины: ");
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
                Console.WriteLine("Вы не ввели значение.");
            else
            {
                int number = Convert.ToInt32(text);
                Console.WriteLine(park[number - 1]);
            }
        }
    }
}
