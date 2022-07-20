using System;

namespace Zoo
{
    internal class Duck : Bird, IFlyable, IWalkable, ISwimable
    {
        public override void Eat() => Console.WriteLine("Утка кушает");

        public void Fly() => Console.WriteLine("Утка летает");

        public override void Move()
        {
            Random random = new Random();
            int value = random.Next(10);
            if (value % 2 == 0)
                Swim();
            else if (value % 3 == 0)
                Fly();
            else
                Walk();
        }

        public void Swim() => Console.WriteLine("Утка плавает");

        public void Walk() => Console.WriteLine("Утка гуляет");
    }
}
