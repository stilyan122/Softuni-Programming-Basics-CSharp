using System;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string tryPassword = Console.ReadLine();
            do
            {
                if (tryPassword==pass)
                {
                    break;
                }
                tryPassword = Console.ReadLine();
            } while (tryPassword!=pass);
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
