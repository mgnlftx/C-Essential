using System;

namespace Zoo
{
    internal class Penguin : Bird, IWalkable, ISwimable
    {
        public override void Eat() => Console.WriteLine("Пингвин кушает");

        public override void Move()
        {
            Random random = new Random();
            int value = random.Next(10);
            if (value % 2 == 0)
                Swim();
            else
                Walk();
        }

        public void Swim() => Console.WriteLine("Пингвин плавает");

        public void Walk() => Console.WriteLine("Пингвин гуляет");
    }
}
