using System;

namespace LoanApp
{
    internal class Program
    {
        static void Main()
        {
            GetLoan();
            Console.Write("Do you want to calculate another loan? (y/n): ");
            string choice = Console.ReadLine()?? "n";

            switch (choice)
            {
                case "y":
                case "Y":
                    Console.Clear();
                    GetLoan();
                    break;
                case "n":
                case "N":
                    Console.WriteLine("Thank you for using the Loan Calculator. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Exiting the program.");
                    break;
            }
        }

        static void GetLoan()
        {
            Console.Write("Enter Loan Amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Annual Interest Rate (%): ");
            double annualRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number of Years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double monthlyRate = (annualRate / 100) / 12;
            int months = years * 12;
            double term = Math.Pow(1 + monthlyRate, months);
            double monthlyPayment = loanAmount * monthlyRate * term / (term - 1);
            double balance = loanAmount;

            Console.WriteLine("\n==============================================================");
            Console.WriteLine("{0,-8}{1,-15}{2,-15}{3,-15}", "Month", "Payment", "Interest", "Balance");
            Console.WriteLine("==============================================================");

            for (int month = 1; month <= months; month++)
            {
                double interest = balance * monthlyRate;
                double principal = monthlyPayment - interest;
                balance -= principal;

                if (balance < 0)
                {
                    balance = 0;
                }


                Console.WriteLine("{0,-8}{1,-15:C2}{2,-15:C2}{3,-15:C2}", month, monthlyPayment, interest, balance);
            }
            Console.WriteLine("==============================================================");
            Console.WriteLine("Monthly Payment: {0:C2}", monthlyPayment);

            Console.ReadLine();
        }


    }
}