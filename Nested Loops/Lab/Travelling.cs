using System;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double earned = 0;
                while (budget > earned)
                {
                    earned += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
