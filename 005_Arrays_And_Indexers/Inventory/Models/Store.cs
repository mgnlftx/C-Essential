using System;

namespace Inventory
{
    internal class Store
    {
        private Article[] articles;

        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        public void GetArticleInfoByIndex(int index)
        {
            if (index < articles.Length)
            {
                articles[index].Show();
            }
            else
            {
                Console.WriteLine("Такого товара нет.");
            }
        }

        public void GetArticleInfoByName(string name)
        {
            Article article = null;
            for (int i = 0; i < articles.Length; i++)
            {
                if (name == articles[i].ProductName)
                {
                    article = articles[i];
                }
            }
            if (article == null)
            {
                Console.WriteLine("Такого товара нет.");
            }
            else
            {
                article.Show();
            }
        }
    }
}
