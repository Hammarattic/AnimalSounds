using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static AnimalSounds.EmnAnimals;

namespace AnimalSounds
{
    internal class FactoryClass
    {
        public Animal CreateAnimal(EnmAnimals animalType)
        {
            return animalType switch
            {
                EnmAnimals.Dog => new dog(),
                EnmAnimals.Sheep => new sheep(),
                EnmAnimals.Cat => new Cat()

            };
        }

        
    } 
}
