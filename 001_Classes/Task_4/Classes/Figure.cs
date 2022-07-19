using System;

namespace Task_4.Classes
{
    internal class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[]
            {
                   point1, point2, point3
            };
        }

        public Figure(Point point1, Point point2, Point point3,
            Point point4)
        {
            points = new Point[]
            {
                   point1, point2, point3, point4
            };
        }

        public Figure(Point point1, Point point2, Point point3,
            Point point4, Point point5)
        {
            points = new Point[]
            {
                   point1, point2, point3, point4, point5
            };
        }

        public double LengthSide(Point A, Point B)
        {
            double result = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            return result;
        }

        public void PerimeterCalculator()
        {
            double result = 0;

            for (int i = 0; i < points.Length; i++)
            {
                double sideLength;

                if (i != points.Length - 1)
                {
                    sideLength = LengthSide(points[i], points[i + 1]);
                }
                else
                {
                    sideLength = LengthSide(points[i], points[0]);
                }

                result += sideLength;
            }

            string name = string.Empty;

            if (points.Length == 3)
            {
                name = "треугольник";
            }
            else if (points.Length == 4)
            {
                name = "прямоугольник";
            }
            else if (points.Length == 5)
            {
                name = "пятиугольник";
            }

            Console.WriteLine($"фигура - {name}, периметр - {result} ");
        }
    }
}
