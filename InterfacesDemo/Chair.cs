using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Chair: Furniture, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }

        //subclass Chair that extends Furniture
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            //initialize the interfaces property with a value in the constructor
            DestructionSound = "ChairExplosionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
            
        }

    }
}
