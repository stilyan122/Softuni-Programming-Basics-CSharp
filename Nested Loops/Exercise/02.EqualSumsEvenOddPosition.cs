using System;

namespace EqualSumsEvenOddPosition
{
    class EqualSumsEvenOddPosition
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
             for (int i = start; i <= end; i++)
             {
                string num = i.ToString();
                int sum1 = 0;
                int sum2 = 0;
                for (int b = 0; b < num.Length; b++)
                {
                    if (b%2==0)
                    {
                        sum1 += (int)num[b]-48;
                    }
                    else
                    {
                        sum2 += (int)num[b] - 48;
                    }
                }
                if (sum1==sum2)
                {
                    Console.Write(i+" ");
                }
             }
            
        }
    }
}
