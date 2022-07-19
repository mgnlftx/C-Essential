using System;

namespace Depo
{
    internal struct Train
    {
        public string NameOfTheDestination { get; set; }

        public int TrainNumber { get; set; }

        public DateTime DepartureTime { get; set; }

        public Train(string nameOfTheDestination, int trainNumber, DateTime departureTime)
        {
            this.NameOfTheDestination = nameOfTheDestination;
            this.TrainNumber = trainNumber;
            this.DepartureTime = departureTime;
        }

        public Train(int trainNumber, DateTime departureTime, string nameOfTheDestination)
        {
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
            NameOfTheDestination = nameOfTheDestination;
        }

        public void Info()
        {
            Console.WriteLine($"Пункт назначения {NameOfTheDestination}, " +
                $"№ поезда {TrainNumber}, время отправления {DepartureTime} ");
        }
    }
}
