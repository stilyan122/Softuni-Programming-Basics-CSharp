using System;

namespace AccountBalance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            double tax = 0.0;
            string command = Console.ReadLine();
            while (command!="NoMoreMoney")
            {
                if (command=="NoMoreMoney")
                {
                    break;
                }
                else
                {
                    double current = double.Parse(command);
                    if (current<0)
                    {
                        Console.WriteLine("Invalid operation!");
                        break;
                    }
                    tax += current;
                    Console.WriteLine($"Increase: {current:f2}");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {tax:f2}");
        }
    }
}
