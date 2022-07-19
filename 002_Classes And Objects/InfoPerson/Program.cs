using System;

/*
 * Требуется:
 Создать класс Employee.
 В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
 инициализирует поля, соответствующие фамилии и имени сотрудника.
 Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
 Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
 оклад и налоговый сбор.
 */

namespace InfoPerson
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Pupkin");

            double salary = employee.Salary("электрик", 10);
            double tax = employee.CalculatorTax(salary);

            Console.WriteLine($"Сотрудник {employee.Surname} {employee.Name} получает оклад {salary}, НДФЛ {tax}");

            Console.ReadKey();
        }
    }
}
