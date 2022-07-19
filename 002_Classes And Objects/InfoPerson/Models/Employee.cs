using System;

namespace InfoPerson
{
    internal class Employee
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public double Salary(string post, int experience)
        {
            double salary = 0;

            switch (post)
            {
                case "электрик":
                    salary = 80000;
                    break;

                case "сантехник":
                    salary = 40000;
                    break;

                case "монтажник":
                    salary = 60000;
                    break;

                default:
                    Console.WriteLine("Такой должности нет");
                    return 0;
            }

            switch (experience)
            {
                case <= 5:
                    salary *= 1.05;
                    break;

                case <= 10:
                    salary *= 1.1;
                    break;

                case <= 15:
                    salary *= 1.15;
                    break;

                case > 15:
                    salary *= 1.2;
                    break;
            }

            return salary;
        }

        public double CalculatorTax(double salary)
        {
            return salary * 0.13;
        }
    }
}
