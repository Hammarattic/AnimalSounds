using System;

namespace AnimalSounds
{
    public abstract class Animal
    {
        
        public string Name { get; set; }

        
        public abstract void Makesound();
    }
}
