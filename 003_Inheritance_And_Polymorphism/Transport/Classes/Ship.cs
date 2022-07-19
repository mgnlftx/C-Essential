using System;

namespace Transport.Classes
{
    internal class Ship : Vehicle
    {
        public int Passengers { get; set; }

        public string HomePort { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine("Информация о корабле");
            base.GetInfo();

            Console.WriteLine($"количество пассажиров {Passengers}");
            Console.WriteLine($"порт приписки {HomePort}");
        }
    }
}
