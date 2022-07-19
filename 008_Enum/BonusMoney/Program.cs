using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
 Присвойте каждой константе значение, задающее количество часов, которые должен отработать
 сотрудник за месяц.
 Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее
 давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему
 положена премия.
 */

namespace BonusMoney
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Accauntant bonus = new Accauntant();

            //Как запросить ввод часов разных должностей, чтобы при этом выглядело красиво, а не парашно?

            Console.WriteLine("Enter the number of hours the electrician has worked");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(bonus.AskForBonus(Post.Electrician, hours));

            Console.WriteLine(new string('=', 30));

            Console.WriteLine("Enter the number of hours the plumber has worked");
            int hours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(bonus.AskForBonus(Post.Plumber, hours1));

            Console.WriteLine(new string('=', 30));

            Console.WriteLine("Enter the number of hours the cook has worked");
            int hours2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(bonus.AskForBonus(Post.Cook, hours2));

            Console.WriteLine(new string('=', 30));

            Console.WriteLine("Enter the number of hours the security1 has worked");
            int hours3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(bonus.AskForBonus(Post.Security1, hours3));

            Console.WriteLine(new string('=', 30));

            Console.WriteLine("Enter the number of hours the security2 has worked");
            int hours4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(bonus.AskForBonus(Post.Security2, hours4));

            Console.WriteLine(new string('=', 30));

            Console.WriteLine("Enter the number of hours the nurse has worked");
            int hours5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(bonus.AskForBonus(Post.Nurse, hours5));

            Console.WriteLine(new string('=', 30));

            Console.WriteLine("Enter the number of hours the cleaning lady has worked");
            int hours6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(bonus.AskForBonus(Post.CleaningLady, hours6));
        }
    }
}
