using Classes;

namespace Task_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass1 myClass1 = new MyClass1();
            myClass1.Say();

            Deuce.MyClass2 myClass2 = new Deuce.MyClass2();
            myClass2.Say();
        }
    }
}
