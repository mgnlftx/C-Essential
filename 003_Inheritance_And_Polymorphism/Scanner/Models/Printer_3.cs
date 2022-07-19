using System;

namespace Scanner
{
    internal class Printer_3 : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(value);
        }
    }
}
