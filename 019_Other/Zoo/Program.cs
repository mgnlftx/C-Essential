using System;

namespace Zoo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Duck duck = new();
            Penguin penguin = new();
            Dolphin dolphin = new();

            duck.Move();
            duck.Eat();

            Console.WriteLine(new string('-', 20));

            penguin.Move();
            penguin.Eat();

            Console.WriteLine(new string('-', 20));

            dolphin.Move();
            dolphin.Eat();

            Console.WriteLine(new string('-', 20));

            ISwimable swimable = duck as ISwimable;
            swimable.Swim();
            IFlyable flyable = duck as IFlyable;
            flyable.Fly();
            IWalkable walkable = duck as IWalkable;
            walkable.Walk();

            Console.WriteLine(new string('-', 20));

            swimable = penguin as ISwimable;
            swimable.Swim();
            walkable = penguin as IWalkable;
            walkable.Walk();

            Console.WriteLine(new string('-', 20));

            swimable = dolphin as ISwimable;
            swimable.Swim();
        }
    }
}
