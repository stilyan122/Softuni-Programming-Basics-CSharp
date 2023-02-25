using System;

namespace Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double sum = Math.Floor(coins);
            double money = Math.Round((coins - sum) * 100);
            double nums = 0;

            while (sum > 0)
            {
                if (sum >= 2)
                {
                    nums += 1;
                    sum -= 2;
                }
                else if (sum >= 1)
                {
                    nums += 1;
                    sum -= 1;
                }
            }
            while (money > 0)
            {
                if (money >= 50)
                {
                    nums += 1;
                    money -= 50;
                }
                else if (money >= 20)
                {
                    nums += 1;
                    money -= 20;
                }
                else if (money >= 10)
                {
                    nums += 1;
                    money -= 10;
                }
                else if (money >= 05)
                {
                    nums += 1;
                    money -= 05;
                }
                else if (money >= 02)
                {
                    nums += 1;
                    money -= 02;
                }
                else if (money >= 01)
                {
                    nums += 1;
                    money -= 01;
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(nums);
        }
    }
}
