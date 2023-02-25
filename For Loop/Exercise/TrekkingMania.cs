using System;

namespace TrekkingMania
{
    class TrekkingMania
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int peopleSum = 0;
            double musalaSum = 0;
            double monblanSum = 0;
            double kilimandjaroSum = 0;
            double k2Sum = 0;
            double everestSum = 0;

            for (int i = 0; i < groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                peopleSum += peopleInGroup;
                if (peopleInGroup<=5)
                {
                    musalaSum += peopleInGroup;
                }
                else if (peopleInGroup > 5 && peopleInGroup<=12)
                {
                    monblanSum += peopleInGroup;
                }
                else if (peopleInGroup > 12 && peopleInGroup <= 25)
                {
                    kilimandjaroSum += peopleInGroup;
                }
                else if (peopleInGroup > 25 && peopleInGroup <= 40)
                {
                    k2Sum += peopleInGroup;
                }
                else if (peopleInGroup >= 41)
                {
                    everestSum += peopleInGroup;
                }
            }
            double p1 = musalaSum / peopleSum * 100;
            double p2 = monblanSum / peopleSum * 100;
            double p3 = kilimandjaroSum / peopleSum * 100;
            double p4 = k2Sum / peopleSum * 100;
            double p5 = everestSum / peopleSum * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
