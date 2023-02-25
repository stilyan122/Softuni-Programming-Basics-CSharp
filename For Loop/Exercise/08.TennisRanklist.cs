using System;

namespace TennisRanklist
{
    class TennisRanklist
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int pointsSum = 0;
            int wonTournamentsCount = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string reachedTime = Console.ReadLine();
                switch (reachedTime)
                {
                    case "F":
                        points += 1200;
                        pointsSum += 1200;
                        break;
                    case "SF":
                        points += 720;
                        pointsSum += 720;
                        break;
                    case "W":
                        points += 2000;
                        pointsSum += 2000;
                        wonTournamentsCount++;
                        break;
                    default:
                        break;
                }
            }
            double averagePoints = pointsSum / tournaments;
            double wonTournamentsPercent = ((double)wonTournamentsCount / (double)tournaments) * 100;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{wonTournamentsPercent:f2}%");
        }
    }
}
