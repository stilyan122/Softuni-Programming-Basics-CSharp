using System;

namespace CinemaTickets
{
    class CinemaTickets
    {
        static void Main(string[] args)
        {
            int standardTicket = 0;
            int studentTicket = 0;
            int kidTicket = 0;
            int totalSeats = 0;

            string movie;
            while ((movie = Console.ReadLine()) != "Finish")
            {
                int allSeatsMovie = int.Parse(Console.ReadLine());
                int currentSeatsMovie = 0;

                string ticketType;
                while (currentSeatsMovie < allSeatsMovie && (ticketType = Console.ReadLine()) != "End")
                {
                    switch (ticketType)
                    {
                        case "standard":
                            standardTicket++;
                            break;
                        case "student":
                            studentTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;
                    }
                    currentSeatsMovie++;
                }

                double utilized = (double)currentSeatsMovie / (double)allSeatsMovie * 100;
                Console.WriteLine($"{movie} - {utilized:F2}% full.");
                totalSeats += currentSeatsMovie;
            }

            Console.WriteLine($"Total tickets: {totalSeats}");
            Console.WriteLine($"{((decimal)studentTicket / totalSeats * 100):F2}% student tickets.");
            Console.WriteLine($"{((decimal)standardTicket / totalSeats * 100):F2}% standard tickets.");
            Console.WriteLine($"{((decimal)kidTicket / totalSeats * 100):F2}% kids tickets.");

        }
    }
}
