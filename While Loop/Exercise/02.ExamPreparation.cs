using System;

namespace ExamPreparation
{
    class ExamPreparation
    {
        static void Main(string[] args)
        {
            int failedThresholds = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < failedThresholds)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4.00)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThresholds} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / solvedProblemsCount:F2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
