using System;

namespace AnimalWorld
{
    internal interface IAnimal
    {
        protected abstract string Name { get; }

        public abstract void MakeSound();

        public void Run(IAnimal animal) => Console.WriteLine($"The {animal.Name} is running.");
    }
}
