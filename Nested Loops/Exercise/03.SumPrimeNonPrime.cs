using System;

namespace SumPrimeNonPrime
{
    class SumPrimeNonPrime
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;
            bool isNonPrime = false;

            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isNonPrime = true;
                        break;
                    }
                }
                if (isNonPrime && number != 1)
                {
                    nonPrimeSum += number;
                    isNonPrime = false;
                }
                else
                {
                    primeSum += number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
