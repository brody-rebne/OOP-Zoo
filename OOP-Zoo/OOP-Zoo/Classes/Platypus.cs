using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    public class Platypus : Animal, ICanSwim
    {
        /// <summary>
        /// The platypus swims
        /// </summary>
        public void Swim()
        {
            Console.WriteLine($"The platypus swims along");
        }
    }
}
