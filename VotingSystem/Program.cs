using System;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Voting App ===");

            Console.Write("Enter your South African ID number: ");
            string idNumber = Console.ReadLine();

            if (idNumber.Length != 13)
            {
                Console.WriteLine("Invalid ID number. Please enter a 13-digit SA ID.");
                return;
               
            }
            int year = int.Parse(idNumber.Substring(0, 2));

            int fullYear;

            if (year <= DateTime.Now.Year % 100)
                fullYear = 2000 + year;
            else
                fullYear = 1900 + year;

            int age = DateTime.Now.Year - fullYear;

            Console.WriteLine($"You are {age} years old.");

            if (age >= 18)
                Console.WriteLine("You can vote.");
            else
                Console.WriteLine("You cannot vote yet.");
        }
    }
}