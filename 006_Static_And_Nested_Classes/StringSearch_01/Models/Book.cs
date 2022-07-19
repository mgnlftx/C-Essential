using System;

namespace StringSearch_01
{
    internal class Book
    {
        public class Note
        {
            private string text = "";

            public string Text
            {
                get { return text; }
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }
            }
        }

        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки: " + str);
        }
    }
}
