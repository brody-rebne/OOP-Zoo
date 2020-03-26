using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    public class Bear : Mammal, ICanHunt
    {
        public void Hunt(Ihuntable prey)
        {
            Console.WriteLine($"The bear hunts the {prey}");
        }
        public override void Eat()
        {
            Console.WriteLine("The bear eats some berries");
        }
    }
}
