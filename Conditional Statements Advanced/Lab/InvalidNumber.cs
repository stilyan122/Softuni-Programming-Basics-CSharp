using System;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number==0||number>=100&&number<=200)
            {
                //number is valid
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
