using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    public class Shark : Fish, ICanHunt
    {
        public void Hunt(Ihuntable prey)
        {
            Console.WriteLine($"The shark has hunted the {prey}");
        }
    }
}
