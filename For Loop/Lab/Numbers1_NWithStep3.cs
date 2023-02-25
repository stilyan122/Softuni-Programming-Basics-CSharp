using System;

namespace Numbers1_NWithStep3
{
    class Numbers1_NWithStep3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
