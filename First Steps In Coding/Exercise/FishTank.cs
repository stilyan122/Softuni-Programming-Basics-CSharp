using System;

namespace FishTank
{
    class FishTank
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            decimal V = length * width * height;
            decimal litersV = (decimal) V * 0.001M;
            decimal space = (decimal) percent / 100;
            decimal needed = litersV * (1 - space);
            Console.WriteLine(needed);
        }
    }
}
