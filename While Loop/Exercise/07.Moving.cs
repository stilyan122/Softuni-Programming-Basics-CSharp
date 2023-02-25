using System;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int V = w * h * l;
            int sum = 0;

            while (command!="Done"&&V-sum>=0)
            {
                if(command!="Done")
                {
                    int box = int.Parse(command);
                    sum += box;
                    if (command == "Done" || V - sum < 0)
                    {
                        break;
                    }
                }
                command = Console.ReadLine();
            }
            if (V>=sum)
            {
                Console.WriteLine($"{V-sum} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {sum-V} Cubic meters more.");
            }
        }
    }
}
