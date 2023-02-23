using System;

namespace Repainting
{
    class Repainting
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int leters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double naylonPrice = (naylon + 2) * 1.50;
            double paintPrice = (paint + 0.10 * paint) * 14.50;
            double litersPrice = leters * 5.00;
            double materialSum = naylonPrice + paintPrice + litersPrice + 0.40;
            double masters = materialSum * 0.30 * 8;
            double totalSum = materialSum + masters;
            Console.WriteLine(totalSum);
        }
    }
}
