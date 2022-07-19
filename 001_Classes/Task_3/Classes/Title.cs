using System;

namespace Task_3.Classes
{
    internal class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(title);
        }
    }
}
