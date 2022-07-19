using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создайте класс AbstractHandler.
 В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
 Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
 Написать программу, которая будет выполнять определение документа и для каждого формата
 должны быть методы открытия, создания, редактирования, сохранения определенного
 формата документа.
 */

namespace Handler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractHandler xml = new XMLHandler();
            AbstractHandler txt = new TXTHandler();
            AbstractHandler doc = new DOCHandler();

            xml.Open();
            xml.Create();
            xml.Chenge();
            xml.Save();

            Console.WriteLine(new string('-', 20));

            txt.Open();
            txt.Create();
            txt.Chenge();
            txt.Save();

            Console.WriteLine(new string('-', 20));

            doc.Open();
            doc.Create();
            doc.Chenge();
            doc.Save();

            Console.ReadKey();
        }
    }
}
