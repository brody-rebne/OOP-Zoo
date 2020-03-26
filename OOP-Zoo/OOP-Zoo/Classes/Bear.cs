using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    public class Bear : Mammal, ICanHunt
    {
        /// <summary>
        /// The bear hunts another animal
        /// </summary>
        /// <param name="prey">The animal to be hunted</param>
        public void Hunt(Ihuntable prey)
        {
            Console.WriteLine($"The bear hunts the {prey}");
        }

        /// <summary>
        /// The bear eats
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("The bear eats some berries");
        }
    }
}
