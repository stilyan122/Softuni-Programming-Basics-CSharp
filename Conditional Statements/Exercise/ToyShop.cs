using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double price = puzzels * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;
            double toys = puzzels + dolls + bears + minions + trucks;
            if (toys>=50)
            {
                price -= 0.25 * price;
            }
            price -= 0.10 * price;
            if (price>=tripPrice)
            {
                Console.WriteLine($"Yes! {(price-tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice-price):f2} lv needed.");
            }
        }
    }
}
