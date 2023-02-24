using System;

namespace LunchBreak
{
    class LunchBreak
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            double breakMin = double.Parse(Console.ReadLine());

            double lunch = breakMin / 8;
            double chill = breakMin / 4;
            double leftTime = breakMin - lunch - chill;
            if (leftTime>=episode)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(leftTime-episode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(episode-leftTime)} more minutes.");
            }
        }
    }
}
