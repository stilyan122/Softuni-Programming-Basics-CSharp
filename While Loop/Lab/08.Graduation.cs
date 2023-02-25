using System;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counterGrade = 0;
            int counterBadGrades = 0;
            bool hasPassed = true;
            double sum = 0.0;
            while (counterBadGrades<2&&counterGrade<12)
            {
                counterGrade++;
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                if (grade<4.00)
                {
                    counterBadGrades++;
                }
                if (counterBadGrades==2)
                {
                    hasPassed = false;
                    break;
                }
            }
            if (hasPassed==false)
            {
                Console.WriteLine($"{name} has been excluded at {counterGrade-1} grade");
            }
            else
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
