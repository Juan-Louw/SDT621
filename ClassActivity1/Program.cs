using System;

class SmartHomeBillSplitter
{
    static double ServiceFee = 15.50;

    static void Main()
    {
        Console.Write("Enter total usage: ");
        double usage = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rate per unit: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number of roommates: ");
        int roommates = Convert.ToInt32(Console.ReadLine());

        //========================================================

        double totalBill = ApplyServiceFee(GetSubtotal(usage, rate));
        int totalCents = (int)(totalBill * 100);
        int perPersonCents = totalCents / roommates;
        int leftoverCents = totalCents % roommates;
        double perPerson = perPersonCents / 100.0;

        //=========================================================

        Console.WriteLine("\n--- Bill Summary ---");
        Console.WriteLine($"Total Bill: R{totalBill}");
        Console.WriteLine($"Each Roommate Pays: R{perPerson}");
        Console.WriteLine($"Leftover Cents: {leftoverCents} cents");
    }
    //Method GetSubTotal
    static double GetSubtotal(double usage, double rate)
    {
        return usage * rate;
    }
    //Method ApplyServiceFee
    static double ApplyServiceFee(double subtotal)
    {
        subtotal += ServiceFee; 
        return subtotal;
    }
}