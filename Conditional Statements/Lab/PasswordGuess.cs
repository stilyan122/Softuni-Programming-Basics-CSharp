using System;

namespace PasswordGuess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string tryPass = Console.ReadLine();
            if (tryPass==password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
