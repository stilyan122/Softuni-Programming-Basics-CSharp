using System;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string accom = "";
            double cost = 0.0;
            if (budget<=100.00)
            {
                place = "Bulgaria";
                if (season=="summer")
                {
                    cost = 0.30 * budget;
                    accom = "Camp";
                }
                else if (season=="winter")
                {
                    cost = 0.70 * budget;
                    accom = "Hotel";
                }
            }
            else if (budget<=1000.00)
            {
                place = "Balkans";
                if (season == "summer")
                {
                    cost = 0.40 * budget;
                    accom = "Camp";
                }
                else if (season == "winter")
                {
                    cost = 0.80 * budget;
                    accom = "Hotel";
                }
            }
            else if (budget>1000.00)
            {
                place = "Europe";
                cost = 0.90 * budget;
                accom = "Hotel";
            }
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{accom} - {cost:f2}");
        }
    }
}
