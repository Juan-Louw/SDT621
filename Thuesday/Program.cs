using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(String[] args)
    {
        //=========================Operators===============================

        //int Mark1 = 50;
        //int Mark2 = 50;

        //int total = Mark1 + Mark2;
        //int difference = Mark1 - Mark2;
        //int product = Mark1 * Mark2;
        //int division = Mark1 / Mark2;

        //Console.WriteLine("Total: " + total);
        //Console.WriteLine("Difference: " + difference);
        //Console.WriteLine("Product: " + product);
        //Console.WriteLine("Division: " + division);

        //=============================Incremental=============================

        //int Bonannas = 10;

        //Bonannas++;
        //Bonannas++;

        //Bonannas--;

        //Console.WriteLine("Final Value: " + Bonannas + " Bonannas");

        //==============================While Loop=========================

        //int number = 0;

        //while (number != 50)
        //{
        //    number++;
        //    Console.WriteLine(number);
        //}

        //==========================User Input===========================

        //Console.Write("Enter your name: ");
        //String name = Console.ReadLine() ?? "Student";

        //Console.Write("Enter your age: ");
        //int age = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter first number: ");
        //double number1 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter secons number: ");
        //double number2 = Convert.ToDouble(Console.ReadLine());


        //double addition = number1 + number2;
        //double subtraction = number1 - number2;
        //double multiplication = number2 * number1;
        //double division = number1 / number2;

        //int wholeNumberResult = (int)addition;

        //Console.WriteLine("\nHello " + name);
        //Console.WriteLine("Your age is: " + age);

        //Console.WriteLine("\nArithnetic Results:");
        //Console.WriteLine("Addition = " + addition);
        //Console.WriteLine("Subtraction = " + subtraction);
        //Console.WriteLine("Multiplication = " + multiplication);
        //Console.WriteLine("Division = " + division);

        //Console.WriteLine("\nCasting Example:");
        //Console.WriteLine("Addition converted to integer = " + wholeNumberResult);

        //Console.WriteLine("\nProgram completed successfully!");

        //=========================Methods==================================

        //DisplayWelcome();

        //int result = AddNumbers(5, 3);

        //Console.WriteLine("The result is: " + result);


        ////Method1
        //static void DisplayWelcome()
        //{
        //    Console.WriteLine("Welcone to the Method example!");
        //}

        ////Method2
        //static int AddNumbers(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //========================Birthday App========================

        //static int getYear()
        //{
        //    return DateTime.Now.Year;
        //}

        //Console.WriteLine("===========Welcome to the Happy Birthday App!!!===========");

        //Console.Write("Enter your Name: ");
        //String name = Console.ReadLine() ?? "user";

        //Console.Write("Enter year of birth: ");
        //int date = Convert.ToInt32(Console.ReadLine());

        //int age = getYear() - date;


        //Console.WriteLine("Happy " + age + "th birtday " + name + " !!!");

        //==============================Method Overload================================

        Console.Write("Enter 1st number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3d number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition Method 1: " + addition(num1, num2));
        Console.WriteLine("Addition Method 2: " + addition(num1, num2, num3));
    }
    static int addition(int num1, int num2)
    {
        return num1 + num2;
    }

    static int addition(int num1, int num2, int num3)
    {
        num3 = num1 + num2;
        return num1 + num2 + num3;
    }
}

