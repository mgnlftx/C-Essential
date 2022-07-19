﻿using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
  Требуется:
 Создать класс Invoice.
 В теле класса создать три поля int account, string customer, string provider, которые должны
 быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
 дальнейшего изменения.
 В теле класса создать два закрытых поля string article, int quantity
 Создать метод расчета стоимости заказа с НДС и без НДС.
 Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
 */

namespace Order
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Alex", "Zulla");

            double orderCost = invoice.CalculateOrderCost(1000, 1, true);

            Console.WriteLine(orderCost);
            Console.ReadKey();
        }
    }
}
