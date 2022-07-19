using System;

namespace Transport.Classes
{
    internal class Plane : Vehicle
    {
        public int Height { get; set; }

        public int Passengers { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine("Информация о самолёте");

            base.GetInfo();

            Console.WriteLine($"высота {Height}");
            Console.WriteLine($"количество пассажиров {Passengers}");
        }
    }
}
