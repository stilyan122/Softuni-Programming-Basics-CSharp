using System;

namespace SkiTrip
{
    class SkiTrip
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0.0;
            double total = 0.0;
            days -= 1;
            if (type== "room for one person")
            {
                price = 18.00;
                total = price * days;
            }
            else if (type=="apartment")
            {
                price = 25.00;
                total = price * days;
                if (days < 10)
                {
                    total -= 0.30 * total;
                }
                else if (days>=10&&days<=15)
                {
                    total -= 0.35 * total;
                }
                else if (days>15)
                {
                    total -= 0.50 * total;
                }
            }
            else if (type == "president apartment")
            {
                price = 35.00;
                total = price * days;
                if (days < 10)
                {
                    total -= 0.10 * total;
                }
                else if (days >= 10 && days <= 15)
                {
                    total -= 0.15 * total;
                }
                else if (days > 15)
                {
                    total -= 0.20 * total;
                }
            }

            if (grade=="positive")
            {
                total += 0.25 * total;
            }
            else if (grade=="negative")
            {
                total -= 0.10 * total;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
