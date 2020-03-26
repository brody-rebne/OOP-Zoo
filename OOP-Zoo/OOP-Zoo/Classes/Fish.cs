using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    public class Fish : Animal, ICanSwim
    {
        public string color { get; set; }

        /// <summary>
        /// The fish swims
        /// </summary>
        public void Swim()
        {
            Console.WriteLine($"The platypus swims along");
        }
    }
}
