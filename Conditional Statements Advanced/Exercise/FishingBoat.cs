using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double naem = 0.0;
            switch (season)
            {
                case "Spring":
                    naem = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    naem = 4200;
                    break;
                case "Winter":
                    naem = 2600;
                    break;
                default:
                    break;
            }

            if (fishers<=6)
            {
                naem -= 0.10 * naem;
            }
            else if (fishers>7&&fishers<=11)
            {
                naem -= 0.15 * naem;
            }
            else if (fishers >= 12)
            {
                naem -= 0.25 * naem;
            }

            if (season!="Autumn"&&fishers%2==0)
            {
                naem -= 0.05 * naem;
            }

            if (budget>=naem)
            {
                Console.WriteLine($"Yes! You have {(budget-naem):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(naem-budget):f2} leva.");
            }
        }
    }
}
