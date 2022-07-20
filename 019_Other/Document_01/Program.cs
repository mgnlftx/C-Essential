using System;

namespace Document_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тело контракта ";

            Footer footer = new Footer();
            footer.Content = "Директор: Хомякова У.И.";

            Document document = new Document(title, body, footer);
            document.Show();

            Console.ReadKey();
        }
    }
}
