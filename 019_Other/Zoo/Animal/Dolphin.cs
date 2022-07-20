using System;

namespace Zoo
{
    internal class Dolphin : Mammal, ISwimable
    {
        public override void Eat() => Console.WriteLine("Дельфин кушает");

        public override void Move() => Swim();

        public void Swim() => Console.WriteLine("Дельфин плавает");
    }
}
