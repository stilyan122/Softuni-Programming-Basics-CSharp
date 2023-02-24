using System;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a*a}:f3");
            }
            else if (type=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b}:f3");
            }
            else if (type=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{r * r * Math.PI}:f3");
            }
            else if (type=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * h / 2}:f3");
            }
        }
    }
}
