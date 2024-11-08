using System;
using static AnimalSounds.EmnAnimals;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryClass factory = new FactoryClass();

            // Creating animals with default names using the first CreateAnimal method
            Animal dog = factory.CreateAnimal(EnmAnimals.Dog);
            dog.Makesound();  // Will use "Fido" as the name by default

            Animal cat = factory.CreateAnimal(EnmAnimals.Cat);
            cat.Makesound();  // Will use "Whiskers" as the name by default

            Animal sheep = factory.CreateAnimal(EnmAnimals.Sheep);
            sheep.Makesound();  // Will use "Dolly" as the name by default

            // Creating animals with custom names using the overloaded CreateAnimal method
            Animal customDog = factory.CreateAnimal(EnmAnimals.Dog, "Buddy");
            customDog.Makesound();  // Will use "Buddy" as the name

            Animal customCat = factory.CreateAnimal(EnmAnimals.Cat, "Luna");
            customCat.Makesound();  // Will use "Luna" as the name
        }
    }
}
