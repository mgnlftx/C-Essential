using System;

namespace EnumsColors
{
    public enum Color
    {
        Green = 1,
        Blue = 2,
        Red = 3,
        Yellow = 4,
        Cyan = 5,
        Magenta = 6
    }

    internal static class Printer
    {
        public static void Print(int color, string text)
        {
            switch (color)
            {
                case (int)Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(text);
                    break;

                case (int)Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(text);
                    break;

                case (int)Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text);
                    break;

                case (int)Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(text);
                    break;

                case (int)Color.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(text);
                    break;

                case (int)Color.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(text);
                    break;

                default:
                    Console.WriteLine("Вы не выбрали цвет! Текст выведен цветом по умолчанию.");
                    break;
            }
        }
    }
}
