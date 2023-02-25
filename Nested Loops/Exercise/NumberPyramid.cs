using System;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            bool end = false;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num+" ");
                    num++;
                    if (num>n)
                    {
                        end = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (end)
                {
                    break;
                }
            }
        }
    }
}
