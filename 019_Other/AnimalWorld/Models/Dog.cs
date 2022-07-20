using System;

namespace AnimalWorld
{
    internal class Dog : IAnimal
    {
        /*protected override*/

        string IAnimal.Name => nameof(Dog);

        public void MakeSound() => Console.WriteLine("Woof-woof");
    }
}
