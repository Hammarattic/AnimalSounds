using static AnimalSounds.EmnAnimals;

namespace AnimalSounds
{
    public class FactoryClass
    {
        // Method to create animal instances based on enum value with a default name
        public Animal CreateAnimal(EnmAnimals animalType)
        {
            return animalType switch
            {
                EnmAnimals.Dog => new Dog("Fido"),
                EnmAnimals.Cat => new Cat("Whiskers"),
                EnmAnimals.Sheep => new Sheep("Dolly"),
                _ => throw new ArgumentException("Invalid animal type")
            };
        }

        // Overloaded method to create animal instances with a variable name
        public Animal CreateAnimal(EnmAnimals animalType, string name)
        {
            return animalType switch
            {
                EnmAnimals.Dog => new Dog(name),
                EnmAnimals.Cat => new Cat(name),
                EnmAnimals.Sheep => new Sheep(name),
                _ => throw new ArgumentException("Invalid animal type")
            };
        }
    }
}
