using System;

namespace SuppliesForSchool
{
    class SuppliesForSchool
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double litersPrice = liters * 1.20;
            double totalPrice = pensPrice + markersPrice + litersPrice;
            double percentAfterDivision = percent / 100;
            double priceWithDiscount = totalPrice - totalPrice * percentAfterDivision;
            Console.WriteLine(priceWithDiscount);
        }
    }
}
