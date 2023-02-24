using System;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 15;
            if (min>=60)
            {
                min -= 60;
                hour++;
                if (hour>23)
                {
                    hour = 0;
                }
            }
            if (min<10)
            {
                Console.WriteLine($"{hour}:0{min}");
            }
            else
            {
                Console.WriteLine($"{hour}:{min}");
            }
        }
    }
}
