using System;

namespace Transport.Classes
{
    internal class Vehicle
    {
        public string Coordinates { get; set; }

        public decimal Price { get; set; }

        public double Speed { get; set; }

        public int YearOrIssue { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"координаты {Coordinates}");
            Console.WriteLine($"цена {Price}");
            Console.WriteLine($"скорость {Speed}");
            Console.WriteLine($"год выпуска {YearOrIssue}");
        }
    }
}
