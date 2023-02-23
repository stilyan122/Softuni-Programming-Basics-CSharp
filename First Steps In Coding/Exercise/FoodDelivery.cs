using System;

namespace FoodDelivery
{
    class FoodDelivery
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggies = int.Parse(Console.ReadLine());

            double priceChicken = chicken * 10.35;
            double priceFish = fish * 12.40;
            double priceVeggies = veggies * 8.15;
            double foodPrice = priceChicken + priceFish + priceVeggies;
            double dessertPrice = 0.20 * foodPrice;
            double totalPrice = foodPrice + dessertPrice + 2.50;
            Console.WriteLine(totalPrice);
        }
    }
}
