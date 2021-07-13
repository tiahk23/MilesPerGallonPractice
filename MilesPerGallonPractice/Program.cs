using System;

namespace MilesPerGallonPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string miles = Console.ReadLine();
            Console.WriteLine("How much gas have you used (in gallons)?");
            string gas = Console.ReadLine();
            int milesPerGallon = int.Parse(miles) / int.Parse(gas);
            Console.WriteLine("Your miles per Gallon is " + milesPerGallon);
        }
    }
}
