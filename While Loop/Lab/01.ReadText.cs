using System;

namespace ReadText
{
    class ReadText
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command!="Stop")
            {
                Console.WriteLine(command);
                command = Console.ReadLine();
            }
        }
    }
}
