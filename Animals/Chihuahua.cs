namespace Labb_6_OOP_ARV
{
    internal class Chihuahua : Dog
    {
        public int Agressiveness { get; set; }
        public Chihuahua(string name = "unknown", Color color = Color.Black, int age = 4, bool hasTail = true, int legs = 4, bool isGoodBoy = true, int agressiveness = 4) : base(name, color, age, hasTail, legs, isGoodBoy)
        {
            Agressiveness = agressiveness;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Yip!");
        }

        public void ChewOnToy()
        {
            Console.WriteLine($"{Name} chews on a toy");
        }
    }

}
