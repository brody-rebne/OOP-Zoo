using System;
using System.Collections.Generic;
using System.Text;
using OOP_Zoo.Interfaces;

namespace OOP_Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        public string sex { get; set; }
        public string furColor { get; set; }
        public abstract void Eat();
    }
}
