using System;

namespace OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    int sum = n1 + n2;
                    if (sum%2==0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                    }
                    break;
                case '-':
                    int diff = n1 - n2;
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {diff} - odd");
                    }
                    break;
                case '*':
                    int mult = n1 * n2;
                    if (mult % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {mult} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {mult} - odd");
                    }
                    break;
                case '/':
                    if (n2==0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        double f1 = (double)n1;
                        double f2 = (double)n2;
                        double div = f1 / f2;
                        Console.WriteLine($"{n1} / {n2} = {div:f2}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        int ost = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {ost}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
