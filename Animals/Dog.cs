using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_ARV
{
    internal class Dog : Animal
    {
        public bool IsGoodBoy  { get; set; }

        public Dog(string name = "unknown", Color color = Color.Black, int age = 4, bool hasTail = true, int legs = 4, bool isGoodBoy = true) : base(name, color, age, hasTail, legs)
        {
            IsGoodBoy = isGoodBoy;
        }

        public override void MakeSound()
        {
            Console.WriteLine("WOOF!");
            
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} fetches a ball");
        }
    }

}
