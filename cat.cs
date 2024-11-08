using NAudio.Wave;
using System;

namespace AnimalSounds
{
    internal class Cat : Animal
    {
        // Constructor that sets the animal's name
        public Cat(string name)
        {
            Name = name;
        }

        // Override Makesound to play sound and print message
        public override void Makesound()
        {
            using (var reader = new WaveFileReader(@"C:\Users\thobi\OneDrive\Skrivebord\csharp\AnimalSounds\Sounds\cat.wav"))
            using (var player = new WaveOutEvent())
            {
                player.Init(reader);
                player.Play();
                Console.WriteLine("Cat goes Meow!");
            }
        }
    }
}
