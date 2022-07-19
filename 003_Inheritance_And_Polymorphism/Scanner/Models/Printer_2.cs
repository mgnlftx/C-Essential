using System;

namespace Scanner
{
    internal class Printer_2 : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine(value);
        }
    }
}
