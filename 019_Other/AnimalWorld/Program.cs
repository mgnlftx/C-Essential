using System;

namespace AnimalWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new();

            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(2);
                IAnimal animal;
                if (randomNumber == 0)
                    animal = new Dog();
                else
                    animal = new Cat();
                animal.Run(animal);
                animal.MakeSound();
            }
        }
    }
}
