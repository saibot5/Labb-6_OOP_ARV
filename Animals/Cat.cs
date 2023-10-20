using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_ARV
{
    internal class Cat : Animal
    {
        public bool IndoorCat { get; set; }
        public Cat(string name = "unknown", Color color = Color.Black, int age = 4, bool hasTail = true, int legs = 4, bool indoor = false) : base(name, color, age, hasTail, legs)
        {
            IndoorCat = indoor;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void LetOut()
        {
            if (IndoorCat)
            {
                Console.WriteLine($"{Name} is an indoor cat and is not allowed to go out");
            }
            else
            {
                Console.WriteLine($"{Name} went out on an adventure");
            }
        }
    }
}
