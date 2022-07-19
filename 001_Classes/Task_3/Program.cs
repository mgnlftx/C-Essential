using System;
using Task_3.Classes;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
 одно строковое поле и метод void Show().
 Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
 Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
 содержание.
 */

namespace Task_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Title title = new Title("title");

            Author author = new Author("author");

            Content content = new Content("content");

            Content content2 = new Content("content2");

            Book book = new Book(title, author, content);

            book.title.Show();

            book.author.Show();

            book.content.Show();

            Book book2 = new Book(title, author, content2);

            book2.title.Show();

            book2.author.Show();

            book2.content.Show();

            Console.ReadKey();
        }
    }
}
