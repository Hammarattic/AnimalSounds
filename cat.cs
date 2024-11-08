using System;
using NAudio.Wave;

namespace AnimalSounds
{
    internal class Cat : Animal
    {
        public override void Makesound()
        {
           
            using (var reader = new WaveFileReader("Sounds/cat.wav"))
            using (var player = new WaveOutEvent())
            {
                player.Init(reader);
                player.Play();  
                Console.WriteLine("Cat goes meow");
            }
        }
    }
}
