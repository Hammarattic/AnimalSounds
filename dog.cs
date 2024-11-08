using NAudio.Wave;
using System;

namespace AnimalSounds
{
    internal class Dog : Animal
    {
        // Constructor that sets the animal's name
        public Dog(string name)
        {
            Name = name;
        }

        // Override Makesound to play sound and print message
        public override void Makesound()
        {
            using (var reader = new WaveFileReader(@"C:\Users\thobi\OneDrive\Skrivebord\csharp\AnimalSounds\Sounds\dog.wav"))
            using (var player = new WaveOutEvent())
            {
                player.Init(reader);
                player.Play();
                Console.WriteLine("Dog goes Woof!");
            }
        }
    }
}
