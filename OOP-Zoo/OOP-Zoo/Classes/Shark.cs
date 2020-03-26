using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    public class Shark : Fish, ICanHunt
    {
        /// <summary>
        /// The shark hunts another animal
        /// </summary>
        /// <param name="prey">The hunted animal</param>
        public void Hunt(Ihuntable prey)
        {
            Console.WriteLine($"The shark has hunted the {prey}");
        }
    }
}
