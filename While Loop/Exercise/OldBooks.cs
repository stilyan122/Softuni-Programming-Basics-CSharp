using System;

namespace OldBooks
{
    class OldBooks
    {
        static void Main(string[] args)
        {
            string favorite = Console.ReadLine();
            bool isFound = false;
            int count = 0;
            while (true)
            {
                string current = Console.ReadLine();

                if (current == favorite)
                {
                    isFound = true;
                    break;
                }
                else if (current == "No More Books")
                {
                    break;
                }
                count++;
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
