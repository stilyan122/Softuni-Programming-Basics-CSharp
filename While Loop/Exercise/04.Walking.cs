using System;

namespace Walking
{
    class Walking
    {
        static void Main(string[] args)
        {
            int target = 10000;
            int steps = 0;
            int currentSteps = 0;
            while (steps < target)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    currentSteps = int.Parse(Console.ReadLine());
                    steps += currentSteps;
                    break;
                }
                else
                {
                    currentSteps = int.Parse(input);
                    steps += currentSteps;
                }
            }
            if (steps >= target)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - target} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{target - steps} more steps to reach goal.");
            }
        }
    }
}
