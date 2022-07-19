using StoreWarehouse;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется: Описать структуру с именем Price, содержащую следующие поля:
 • название товара;
 • название магазина, в котором продается товар;
 • стоимость товара в гривнах.
 Написать программу, выполняющую следующие действия:
 • ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны
 быть упорядочены в алфавитном порядке по названиям магазинов);
 • вывод на экран информации о товарах, продающихся в магазине, название которого введено с
 клавиатуры (если такого магазина нет, вывести исключение).
 */

int k = 2;
Price[] prices = new Price[k];
for (int i = 0; i < k; i++)
{
    Console.WriteLine("Название товара: ");
    prices[i].ProductName = Console.ReadLine();
    Console.WriteLine("Название магазина: ");
    prices[i].ShopName = Console.ReadLine();
    Console.WriteLine("Стоимость товара в рублях :");
    prices[i].Priced = Convert.ToDecimal(Console.ReadLine());
}

for (int i = 0; i < k; i++)
{
    Console.WriteLine(prices[i]);
}

Console.WriteLine("Введите название товара: ");
string nameProd = Console.ReadLine();

//Помогите пожалуйста :\

//int r = 0;
//for (int i = 0; i < k; i++)
//{
//    try
//    {
//        prices[i].ProductName == nameProd
//        Console.WriteLine(prices[i]);

//        r++;
//    }
//    catch
//    {
//        Console.WriteLine("Такого товара нет!");
//    }
//}
