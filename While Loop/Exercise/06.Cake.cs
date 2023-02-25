using System;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakePieses = length * width;

            string line = Console.ReadLine();
            bool isCakeEnough = true;

            while (line != "STOP")
            {
                int currentPieses = int.Parse(line);
                cakePieses -= currentPieses;
                if (cakePieses < 0)
                {
                    isCakeEnough = false;
                    break;
                }
                line = Console.ReadLine();
            }
            if (isCakeEnough == true)
            {
                Console.WriteLine($"{cakePieses} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieses)} pieces more.");
            }
        }
    }
}
