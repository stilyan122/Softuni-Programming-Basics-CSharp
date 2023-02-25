using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sum1 += num;
                }
                else
                {
                    sum2 += num;
                }
            }
            if (sum1==sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
