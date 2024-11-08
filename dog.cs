using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class dog: Animal
    {
        

        public override void Makesound()
        {
            using (var reader = new WaveFileReader("Sounds/dog.wav"))
            using (var player = new WaveOutEvent())
            {
                player.Init(reader);
                player.Play();
                Console.WriteLine("dog go vof");
            }
           
        }
    }
}
