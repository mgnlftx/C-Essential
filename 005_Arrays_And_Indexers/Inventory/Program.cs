using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс Article, содержащий следующие закрытые поля:
 •название товара;
 •название магазина, в котором продается товар;
 •стоимость товара в гривнах.
 Создать класс Store, содержащий закрытый массив элементов типа Article.
 Обеспечить следующие возможности:
 •вывод информации о товаре по номеру с помощью индекса;
 •вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаровнет, выдать соответствующее сообщение;
 Написать программу, вывода на экран информацию о товаре.
 */

namespace Inventory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Article bread = new Article(50, "bread", "spar");

            Article milk = new(70, "milk", "spar");

            Article potato = new(40, "potato", "spar");

            Article[] articles = new Article[] { bread, milk, potato };
            Store store = new Store(articles);

            store.GetArticleInfoByIndex(690);
            store.GetArticleInfoByName("milk");

            Console.ReadKey();
        }
    }
}
