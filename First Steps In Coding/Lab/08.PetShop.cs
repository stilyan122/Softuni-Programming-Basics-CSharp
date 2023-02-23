using System;

namespace PetShop
{
    class PetShop
    {
        static void Main(string[] args)
        {
            int dogPackets = int.Parse(Console.ReadLine());
            int catPackets = int.Parse(Console.ReadLine());
            double dogFood = dogPackets * 2.50;
            double catFood = catPackets * 4.00;
            double totalFood = dogFood + catFood;
            Console.WriteLine(totalFood+" lv.");
        }
    }
}
