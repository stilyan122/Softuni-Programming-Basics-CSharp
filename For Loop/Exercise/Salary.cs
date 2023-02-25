using System;

namespace Salary
{
    class Salary
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            bool hasMoney = true;
            for (int i = 0; i < tabs; i++)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                    default:
                        break;
                }
                if (salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    hasMoney = false;
                    break;
                }
            }
            if (hasMoney)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
