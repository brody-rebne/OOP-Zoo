using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    class Monkey : Mammal, Ihuntable
    {
        /// <summary>
        /// The monkey pets another animal
        /// </summary>
        /// <param name="animal">The animal to be petted</param>
        public void Pet(Mammal animal)
        {
            Console.WriteLine($"The monkey pets {animal} gently");
        }

        /// <summary>
        /// The monkey eats food
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"The monkey finds something to eat");
        }
    }
}
