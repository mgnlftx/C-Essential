using System;

namespace Task_3.Classes
{
    internal class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
        }
    }
}
