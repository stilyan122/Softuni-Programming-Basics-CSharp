using System;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double capacity = double.Parse(Console.ReadLine());
            double pricePerProduct = 0.0;
            switch (town)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            pricePerProduct = 0.50;
                            break;
                        case "water":
                            pricePerProduct = 0.80;
                            break;
                        case "beer":
                            pricePerProduct = 1.20;
                            break;
                        case "sweets":
                            pricePerProduct = 1.45;
                            break;
                        case "peanuts":
                            pricePerProduct = 1.60;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            pricePerProduct = 0.40;
                            break;
                        case "water":
                            pricePerProduct = 0.70;
                            break;
                        case "beer":
                            pricePerProduct = 1.15;
                            break;
                        case "sweets":
                            pricePerProduct = 1.30;
                            break;
                        case "peanuts":
                            pricePerProduct = 1.50;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            pricePerProduct = 0.45;
                            break;
                        case "water":
                            pricePerProduct = 0.70;
                            break;
                        case "beer":
                            pricePerProduct = 1.10;
                            break;
                        case "sweets":
                            pricePerProduct = 1.35;
                            break;
                        case "peanuts":
                            pricePerProduct = 1.55;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            double cost = pricePerProduct * capacity;
            Console.WriteLine(cost);
        }
    }
}
