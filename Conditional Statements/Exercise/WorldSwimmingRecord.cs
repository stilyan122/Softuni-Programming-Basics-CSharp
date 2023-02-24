using System;

namespace WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double timeFor1M = double.Parse(Console.ReadLine());
            double neededSec = length * timeFor1M;
            double timeWith12S = Math.Floor(length / 15) * 12.5;
            double totalTime = timeWith12S + neededSec;
            if (record<=totalTime)
            {
                Console.WriteLine($"No, he failed! He was {(totalTime-record):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
