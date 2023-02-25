using System;

namespace CleverLily
{
    class CleverLily
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int counterMoney = 10;
            int totalMoney = 0;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    totalMoney += counterMoney;
                    counterMoney += 10;
                    totalMoney -= 1;
                }
                else
                {
                    toys++;
                }
            }
            totalMoney += toys * toyPrice;
            if (totalMoney>=washMachinePrice)
            {
                Console.WriteLine($"Yes! {(totalMoney-washMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washMachinePrice-totalMoney):f2}");
            }
        }
    }
}
