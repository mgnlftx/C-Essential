using System;

namespace AnimalWorld
{
    internal class Cat : IAnimal
    {
        /*protected override*/

        string IAnimal.Name => nameof(Cat);

        public void MakeSound() => Console.WriteLine("Meow-meow");
    }
}
