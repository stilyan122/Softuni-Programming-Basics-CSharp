using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int min = int.MaxValue;
            while (command != "Stop")
            {
                int curr = int.Parse(command);
                if (min > curr)
                {
                    min = curr;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
