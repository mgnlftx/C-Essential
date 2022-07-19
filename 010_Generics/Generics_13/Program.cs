using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
 который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места
 заполнения типом – Т).
 */

namespace Generics_13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = MyClass<int>.FactoryMethod();

            Console.WriteLine(a.GetType().Name);

            Program program = MyClass<Program>.FactoryMethod();

            Console.WriteLine(program.GetType().Name);
        }
    }
}
