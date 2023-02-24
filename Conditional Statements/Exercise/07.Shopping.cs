using System;

namespace Shopping
{
    class Shopping
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int vCards = int.Parse(Console.ReadLine());
            int procc = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double vCardsPrice = vCards * 250;
            double proccPrice = 0.35 * vCardsPrice * procc;
            double ramPrice = 0.10 * vCardsPrice * ram;
            double total = vCardsPrice + proccPrice + ramPrice;
            if (vCards>procc)
            {
                total -= 0.15 * total;
            }
            if (budget>=total)
            {
                Console.WriteLine($"You have {(budget-total):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(total-budget):f2} leva more!" );
            }
        }
    }
}
