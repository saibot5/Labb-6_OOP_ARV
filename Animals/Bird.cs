namespace Labb_6_OOP_ARV
{
    class Bird : Animal
    {
        public int Wingspan { get; set; }
        public Bird(string name = "Unknown", Color color = Color.Black, int age = 1, bool hasTail = false, int legs = 2, int wingspan = 10) : base(name, color, age, hasTail, legs)
        {
            Wingspan = wingspan;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies away");
        }

        public override void MakeSound()
        {
            Console.WriteLine("chirp");
        }
    }
}
