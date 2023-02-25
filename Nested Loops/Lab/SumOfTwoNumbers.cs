using System;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int position = -1;
            int firstNum = 0;
            int secondNum = 0;
            int counter = 0;
            bool isFound = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    int add = i + j;
                    counter++;
                    if (add==magic)
                    {
                        position = counter;
                        firstNum = i;
                        secondNum = j;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Combination N:{position} ({firstNum} + {secondNum} = {magic})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
