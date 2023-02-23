using System;

namespace VacationBooksList
{
    class VacationBooksList
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesFor1Hour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalTime = pages / pagesFor1Hour;
            int needTime = totalTime / days;
            Console.WriteLine(needTime);
        }
    }
}
