using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            double s4 = 0;
            double s5 = 0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum ++;
                if (number < 200)
                {
                    s1 ++;
                }
                else if (number >= 200 && number <= 399)
                {
                    s2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    s3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    s4 ++;
                }
                else if (number >= 800)
                {
                    s5++;
                }
            }

            double p1 = s1 / sum * 100;
            double p2 = s2 / sum * 100;
            double p3 = s3 / sum * 100;
            double p4 = s4 / sum * 100;
            double p5 = s5 / sum * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
