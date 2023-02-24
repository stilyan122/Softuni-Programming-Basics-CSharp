using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int tickets = rows * cols;
            double price = 0.0;
            switch (projection)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
                default:
                    break;
            }
            double total = tickets * price;
            Console.WriteLine($"{total:f2}");
        }
    }
}
