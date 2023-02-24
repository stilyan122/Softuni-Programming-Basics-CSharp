using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double appPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.00;
                    appPrice = 65.00;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    appPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00;
                    appPrice = 77.00;
                    break;
                default:
                    break;
            }
            double totalStudio = nights * studioPrice;
            double totalApp = nights * appPrice;
            if (nights > 7 && nights<=14 && (month=="May"||month=="October"))
            {
                totalStudio -= 0.05 * totalStudio;
            }
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                totalStudio -= 0.30 * totalStudio;
            }
            if (nights > 14 && (month == "June" || month == "September"))
            {
                totalStudio -= 0.20 * totalStudio;
            }
            if (nights > 14)
            {
                totalApp -= 0.10 * totalApp;
            }
            Console.WriteLine($"Apartment: {totalApp:f2} lv.");
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
        }
    }
}
