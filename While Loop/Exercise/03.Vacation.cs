using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int spendDays = 0;
            int days = 0;
            bool isManaged = true;

            while (ownedMoney < neededMoney)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                days++;
                if (action == "spend")
                {
                    spendDays++;
                    if (spendDays == 5)
                    {
                        isManaged = false;
                        break;
                    }

                    ownedMoney -= money;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                }
                else if (action == "save")
                {
                    spendDays = 0;

                    ownedMoney += money;
                }

            }
            if (isManaged)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }

        }
    }
}
