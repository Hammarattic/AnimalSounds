namespace AnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryClass factory = new FactoryClass();


            Animal dog =factory.CreateAnimal(EmnAnimals.EnmAnimals.Dog);
            dog.Makesound();

            Animal cat = factory.CreateAnimal(EmnAnimals.EnmAnimals.Cat);
            cat.Makesound();

            Animal sheep = factory.CreateAnimal(EmnAnimals.EnmAnimals.Sheep);
            sheep.Makesound();


        }
    }
}
