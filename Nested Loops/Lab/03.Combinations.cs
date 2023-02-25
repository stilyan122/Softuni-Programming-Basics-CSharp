using System;

namespace Combinations
{
    class Combinations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int a = 0; a <= n; a++)
                {
                    for (int b = 0; b <= n; b++)
                    {
                        int add = i + a + b;
                        if (add==n)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
