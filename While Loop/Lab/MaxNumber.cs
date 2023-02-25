using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int max = int.MinValue;
            while (command!="Stop")
            {
                int curr = int.Parse(command);
                if (max<curr)
                {
                    max = curr;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
