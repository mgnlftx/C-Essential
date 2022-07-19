using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта
 назначения, номер поезда, время отправления.
 Написать программу, выполняющую следующие действия:
 - ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть
 упорядочены по номерам поездов);
 - вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,
 вывести соответствующее сообщение).
 */

namespace Depo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Train train = new Train(); //Надо или нет?
            Train[] infoTrain = new Train[8];

            for (int i = 0; i < infoTrain.Length; i++)
            {
                Console.WriteLine("Введите название пункта назначения: ");
                string nameOfTheDestination = Console.ReadLine();

                Console.WriteLine("Введите номер поезда: ");
                int trainNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите дату отправления: ");
                DateTime departureTime = DateTime.Parse(Console.ReadLine());

                infoTrain[i] = new Train(trainNumber, departureTime, nameOfTheDestination);
            }
            //Что дальше?...

            //Ниже говно из интернета, которое как по мне не подходит.

            //Console.WriteLine("Введите название пункта назначения для поиска или enter для выхода: ");
            //string text = Console.ReadLine();

            //while (text != "enter")
            //{
            //    bool trainFound = false;
            //    for (int i = 0; i < infoTrain.Length; i++)
            //    {
            //        if (infoTrain[i].NameOfTheDestination == text)
            //        {
            //            Console.WriteLine(infoTrain[i]);
            //            trainFound = true;
            //        }
            //    }
            //    if (!trainFound)
            //        Console.WriteLine("Ничего не найдено. Повторите попытку");
            //}
        }
    }
}
