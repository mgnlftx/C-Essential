using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс с именем Address.
 В теле класса требуется создать поля: index, country, city, street, house, apartment.
 Для каждого поля, создать свойство с двумя методами доступа.
 Создать экземпляр класса Address.
 В поля экземпляра записать информацию о почтовом адресе.
 Выведите на экран значения полей, описывающих адрес.
 */

namespace Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Address instance = new Address();

            instance.Index = 111020;
            Console.WriteLine(instance.Index);

            instance.Country = "Russia";
            Console.WriteLine(instance.Country);

            instance.City = "Moscow";
            Console.WriteLine(instance.City);

            instance.Street = "Borovaya Street";
            Console.WriteLine(instance.Street);

            instance.House = 16;
            Console.WriteLine(instance.House);

            instance.Apartament = 20;
            Console.WriteLine(instance.Apartament);

            Console.ReadKey();
        }
    }
}
