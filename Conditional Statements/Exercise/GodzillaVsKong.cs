using System;

namespace GodzillaVsKong
{
    class GodzillaVsKong
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double personCostume = double.Parse(Console.ReadLine());
            double decor = 0.10 * budget;
            double costumes = personCostume * people;
            if (people>150)
            {
                costumes -= 0.10 * costumes;
            }
            double total = costumes + decor;
            if (budget>=total)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget-total):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(total-budget):f2} leva more.");
            }
        }
    }
}
