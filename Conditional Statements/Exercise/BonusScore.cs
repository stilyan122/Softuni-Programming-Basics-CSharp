using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (points<=100)
            {
                bonus = 5;
            }
            else if (points>100&&points<=1000)
            {
                bonus = 0.20 * points;
            }
            else if (points>1000)
            {
                bonus = 0.10 * points;
            }

            if (points%2==0)
            {
                bonus += 1;
            }
            else if (points%5==0)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(points+bonus);
        }
    }
}
