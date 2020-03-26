using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    class Monkey : Mammal, Ihuntable
    {
        public void Pet(Mammal animal)
        {
            Console.WriteLine($"The monkey pets {animal} gently");
        }
        public override void Eat()
        {
            Console.WriteLine($"The monkey finds something to eat");
        }
    }
}
