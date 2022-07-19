using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
 заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
 (при создании экземпляра данного класса) без возможности его дальнейшего изменения.
 Реализуйте вывод на экран информации о пользователе.
 */

namespace UserInformation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user = new User("Natella", "Natalia", "Stepanova", 39);
            User user1 = new User();
            // user.Login = "Natella";
            Console.WriteLine(user.Login);

            //user.Name = "Natalia";
            Console.WriteLine(user.Name);

            //user.Surname = "Stepanova";
            Console.WriteLine(user.Surname);

            // user.Age = 39;
            Console.WriteLine(user.Age);

            Console.WriteLine(user.Date);

            Console.ReadKey();
        }
    }
}
