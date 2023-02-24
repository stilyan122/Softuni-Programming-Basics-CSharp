using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;
            switch (flower)
            {
                case "Roses":
                    price = 5.00;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3.00;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
                default:
                    break;
            }

            double cost = price * count;
            if (flower=="Roses" && count > 80)
            {
                cost -= 0.10 * cost;
            }
            else if (flower == "Dahlias" && count > 90)
            {
                cost -= 0.15 * cost;
            }
            else if (flower == "Tulips" && count > 80)
            {
                cost -= 0.15 * cost;
            }
            else if (flower == "Narcissus" && count < 120)
            {
                cost += 0.15 * cost;
            }
            else if (flower == "Gladiolus" && count < 80)
            {
                cost += 0.20 * cost;
            }
            if (budget>=cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {(budget-cost):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(cost-budget):f2} leva more.");
            }
        }
    }
}
