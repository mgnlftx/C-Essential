using ClassLibrary1;
using MyNamespace;
using System;

/*
 * Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом приложении.
 + Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному
   методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки.
 */

namespace MyFuckingProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Class1 inst = new Class1();
            inst.Method();

            Class instance = new Class();
            instance.Method();

            Console.ReadKey();
        }
    }
}
