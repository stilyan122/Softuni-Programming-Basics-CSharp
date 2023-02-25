using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int numToAdd = int.Parse(Console.ReadLine());
            do
            {
                sum += numToAdd;
                if (sum>=number)
                {
                    break;
                }
                numToAdd = int.Parse(Console.ReadLine());
            }
            while (sum < number);
            Console.WriteLine(sum);
        }
    }
}
