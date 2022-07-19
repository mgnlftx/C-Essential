using System;

namespace Matrix
{
    internal class MyMatrix
    {
        private int row;
        private int column;

        public int RowCounter
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
                CreateMatrix();
            }
        }

        public int ColumnCounter
        {
            get
            {
                return column;
            }

            set
            {
                column = value;
                CreateMatrix();
            }
        }

        public int[,] Matrix = null;

        public MyMatrix()
        {
        }

        public MyMatrix(int row, int column)
        {
            this.row = row;

            this.column = column;
            CreateMatrix();
        }

        public void Show()
        {
            if (Matrix != null)
            {
                for (int i = 0; i < RowCounter; i++)
                {
                    for (int k = 0; k < ColumnCounter; k++)
                    {
                        Console.Write($"{Matrix[i, k]} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не задана");
            }
        }

        private void CreateMatrix()
        {
            if (RowCounter > 0 && ColumnCounter > 0)
            {
                Random rnd = new Random();

                if (Matrix == null)
                {
                    Matrix = new int[RowCounter, ColumnCounter];
                    for (int i = 0; i < RowCounter; i++)
                    {
                        for (int k = 0; k < ColumnCounter; k++)
                        {
                            Matrix[i, k] = rnd.Next(10);
                        }
                    }
                }
                else
                {
                    int[,] newMatrix = new int[RowCounter, ColumnCounter];

                    for (int i = 0; i < RowCounter; i++)
                    {
                        for (int k = 0; k < ColumnCounter; k++)
                        {
                            if (i < Matrix.GetLength(0) && k < Matrix.GetLength(1))
                            {
                                newMatrix[i, k] = Matrix[i, k];
                            }
                            else
                            {
                                newMatrix[i, k] = rnd.Next(10);
                            }
                        }
                    }
                    Matrix = newMatrix;
                }
            }
            else
            {
                Console.WriteLine("Не заданы все параметры матрицы");
            }
        }
    }
}
