using System;

namespace Task_3.Classes
{
    internal class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
        }
    }
}
