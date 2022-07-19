using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить
 количество дней до его следующего дня рождения.
 */

namespace CounterBirthday
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите дату вашего ближайшего дня рождения, в формате: гггг, мм, дд: ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            DateTime today = DateTime.Now;

            TimeSpan left = birthday - today;
            Console.WriteLine("До дня рождения осталось " + left.Days + " дней");
            Console.WriteLine("До дня рождения осталось " + left.TotalHours + " часов");

            Console.ReadKey();
        }
    }
}
