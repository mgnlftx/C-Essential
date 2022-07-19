using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера
 с возможностью изменения числа строк и столбцов.
 Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.
 */

namespace Matrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyMatrix matrix = new(2, 3);

            matrix.Show();

            Console.WriteLine(new string('=', 10));

            matrix.RowCounter = 4;
            matrix.ColumnCounter = 2;

            matrix.Show();
        }
    }
}
