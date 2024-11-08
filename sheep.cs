using NAudio.Wave;
using System;

namespace AnimalSounds
{
    internal class Sheep : Animal
    {
        // Constructor that sets the animal's name
        public Sheep(string name)
        {
            Name = name;
        }

        // Override Makesound to play sound and print message
        public override void Makesound()
        {
            using (var reader = new WaveFileReader(@"C:\Users\thobi\OneDrive\Skrivebord\csharp\AnimalSounds\Sounds\sheep.wav"))
            using (var player = new WaveOutEvent())
            {
                player.Init(reader);
                player.Play();
                Console.WriteLine("Sheep goes Baaah!");
            }
        }
    }
}
