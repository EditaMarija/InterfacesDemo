using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Car: Vehicle, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }

        //new property to store list of destroyable objects nearby
        public List<IDestroyable> DestroyablesNearby { get; set; }

        //subclass Car that extends Vehicle
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            //initialize the interfaces property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            //initialize the list of of destroyable objects nearby
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            //when a car gets destroyed we should play destruction sound and create fire
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            //go through each destroyable object in the list and call its destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
