using System;

namespace Building
{
    class Building
    {
        static void Main(string[] args)
        {
            int stores = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string type = "";

            for (int row = stores; row >= 1; row--)
            {
                for (int col = 0; col < rooms; col++)
                {
                    if (row == stores)
                    {
                        type = "L";
                    }
                    else
                    {
                        if (row % 2 == 0)
                        {
                            type = "O";
                        }
                        else
                        {
                            type = "A";
                        }
                    }

                    Console.Write($"{type}{row}{col} ");
                }
                Console.WriteLine();
            }
        }
    }
}
