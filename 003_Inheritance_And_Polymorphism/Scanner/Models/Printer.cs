using System;

namespace Scanner
{
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.WriteLine(value);
        }
    }
}
