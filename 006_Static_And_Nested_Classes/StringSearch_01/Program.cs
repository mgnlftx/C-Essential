using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который
 позволит сохранять заметки читателя.
 */

namespace StringSearch_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Book.Note note = new Book.Note();

            note.Text = "I like it!";
            note.Text = "Highlight";

            Console.WriteLine(note.Text);
        }
    }
}
