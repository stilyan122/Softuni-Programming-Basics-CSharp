using System;

namespace DepositCalculator
{
    class DepositCalculator
    {
        static void Main(string[] args)
        {
            double depositetSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());
            double lihva = depositetSum * (yearPercent / 100);
            double lihvaFor1Month = lihva / 12;
            double totalSum = depositetSum + months * lihvaFor1Month;
            Console.WriteLine(totalSum);
        }
    }
}
