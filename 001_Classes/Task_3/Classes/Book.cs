namespace Task_3.Classes
{
    internal class Book
    {
        public Title title;

        public Author author;

        public Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;

            this.author = author;

            this.content = content;
        }
    }
}
