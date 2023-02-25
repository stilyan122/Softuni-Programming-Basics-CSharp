using System;

namespace TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double allGrades = 0;
            int gradeCount = 0;

            while (input != "Finish")
            {
                string presentation = input;
                double currentGrades = 0;


                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currentGrades += grade;
                    allGrades += grade;
                    gradeCount++;
                }
                Console.WriteLine($"{presentation} - {currentGrades / n:F2}.");

                input = Console.ReadLine();
            }
            double averageGrades = allGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {averageGrades:F2}.");
        }
    }
}
