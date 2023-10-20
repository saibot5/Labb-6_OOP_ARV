
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_ARV
{
    abstract internal class Animal
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public int Age { get; set; }
        public bool HasTail { get; set; }
        public int Legs { get; set; }

        public Animal(string name = "Unknown", Color color = Color.Black, int age = 1, bool hasTail = true, int legs = 4)
        {
            Name = name;
            Color = color;
            Age = age;
            HasTail = hasTail;
            Legs = legs;
        }

        public void Sleep()
        {
            Console.WriteLine("ZzZz");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} Eats");
        }

        abstract public void MakeSound();

    }
}
