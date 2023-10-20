namespace Labb_6_OOP_ARV
{
    internal class SaintBernard : Dog
    {
        public bool HasBrandyBarrel { get; set; }
        public SaintBernard(string name = "unknown", Color color = Color.Black, int age = 4, bool hasTail = true, int legs = 4,  bool isGoodBoy = true, bool hasBrandyBarrel = true) : base(name, color, age, hasTail, legs, isGoodBoy)
        {
            HasBrandyBarrel = hasBrandyBarrel;
        }

        public override void MakeSound()
        {
            Console.WriteLine("BOOF!");
        }

        public void ServeBrandy()
        {
            if (HasBrandyBarrel)
            {
                Console.WriteLine($"{Name} serves brandy");
            }
            else
            {
                Console.WriteLine($"{Name} dont have a brandy barrel");
            }
        }
    }

}
