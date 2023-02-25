using System;

namespace Oscars
{
    class Oscars
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());
            bool hasWon = false;
            for (int i = 0; i < jury; i++)
            {
                string juryName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                double pointsToGive = (juryName.Length * points) / 2;
                academyPoints += pointsToGive;
                if (academyPoints>1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {academyPoints:f1}!");
                    hasWon = true;
                    break;
                }
            }
            if (hasWon==false)
            {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5-academyPoints):f1} more!");
            }
        }
    }
}
