

using System.Globalization;

namespace Labb_6_OOP_ARV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAnimals();
        }

        private static void PrintAnimals()
        {
            //create instances of diffrent animals
            SaintBernard saintBernard = new SaintBernard("Bernard", Color.brown, 5, true, 4, true, true);
            Cat cat = new Cat("Simba", Color.White,2, false, 4, false);
            Bird bird = new Bird("Polly", Color.Black,1, false, 2, 10);

            //creates a default Chihuahua
            Chihuahua chihuahua = new Chihuahua();

            //prints diffrent sounds and actions
            saintBernard.Fetch();
            saintBernard.MakeSound();
            Console.WriteLine();

            cat.Eat(); 
            cat.MakeSound();
            cat.Sleep();

            Console.WriteLine();

            bird.MakeSound();
            bird.Fly();

            Console.WriteLine();
            chihuahua.Eat();
            chihuahua.MakeSound();
        }
    }
}