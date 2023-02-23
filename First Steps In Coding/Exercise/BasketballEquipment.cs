using System;

namespace BasketballEquipment
{
    class BasketballEquipment
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double shoes = tax - tax * 0.40;
            double ekip = shoes - shoes * 0.20;
            double ball = ekip / 4;
            double accessories = ball / 5;
            double total = tax + shoes + ekip + ball + accessories;
            Console.WriteLine(total);
        }
    }
}
