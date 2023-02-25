using System;

namespace Sequence2kPlus1
{
    class Sequence2kPlus1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            Console.WriteLine(1);
            while (k<=n)
            {
                if (k>n)
                {
                    break;
                }
                else
                {
                    k = k * 2 + 1;
                    if(k<=n)
                    Console.WriteLine(k);
                }
            }
        }
    }
}
