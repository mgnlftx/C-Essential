using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс, представляющий учебный класс ClassRoom.
 Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
 Write(), void Relax().
 Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
 Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
 Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
 Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
 Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
 писать, отдыхать.
 */

namespace School
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExcelentPupil x = new ExcelentPupil();
            GoodPupil y = new GoodPupil();
            BadPupil u = new BadPupil();
            ClassRoom classRoom = new ClassRoom(x, y, u);

            for (int i = 0; i < classRoom.Pupils.Length; i++)
            {
                Console.WriteLine($"Ученик {i + 1}");
                classRoom.Pupils[i].Read();
                classRoom.Pupils[i].Relax();
                classRoom.Pupils[i].Study();
                classRoom.Pupils[i].Write();
                Console.WriteLine(new String('=', 50));
            }

            Console.ReadKey();
        }
    }
}
