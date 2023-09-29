//Write a Program to Check if a Number Is Positive or Negative in C#. Make sure all exceptions are handled.

using System;
namespace NegativeOrPositive;

class Program
{
    static void Main()
    {
        string UserInput;
        double UserOutput;
        while (true)
        {
            do
            {
                Console.Write("Please enter a number: ");
                UserInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(UserInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    continue;
                }

                if (!double.TryParse(UserInput, out UserOutput))
                {
                    Console.WriteLine("Invalid input! Only numbers are accepted!");
                    
                }
            } while (string.IsNullOrWhiteSpace(UserInput) || !double.TryParse(UserInput,out UserOutput));

            if (UserOutput > 0)
            {
                Console.WriteLine("{0} is a positive number ",UserOutput);
            }
            else if (UserOutput < 0)
            {
                Console.WriteLine("{0} is a negative number ",UserOutput);
            }
            else
            {
                Console.WriteLine("{0} is neither a negative or a positive number ",UserOutput);
            }
            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0')Environment.Exit(0);
        }
    }
}