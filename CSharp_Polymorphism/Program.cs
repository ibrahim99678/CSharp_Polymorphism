using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism : Greek word that means to " have many forms"
            //              objects can be identified by more than one type 
            //              Ex-A dog is also :canine, Animal , Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = {car, bicycle, boat};
        
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();

        }
        class Vehicle
        {
            public virtual void Go()
            {

            }
        }
        class Car : Vehicle
        {

            public override void Go()
            {
                Console.WriteLine("The car is Moving !!@");
            }
        }
        class Bicycle : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The Bicycle is moving!");
            }
        }
        class Boat : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The Boat is Moving!");
            }

        }
    }
}
