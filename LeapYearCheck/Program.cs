// Write a C# Program to check whether a Year is Leap Year or Not. Handle ALL exceptions...

using System;
namespace LeapYearCheck;

class Program
{
    static void Main()
    {
        string userInput;
        int userOutput;
        while (true)
        {
            do
            {
                Console.Write("Please enter the year: ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    continue;
                }

                if (!int.TryParse(userInput,out userOutput))
                {
                    Console.WriteLine("Error! Only whole numbers are accepted!");
                }
            } while (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput,out userOutput));

            if (userOutput % 4 == 0)
            {
                Console.WriteLine("The year {0} is a Leap Year",userInput);
            }
            else
            {
                Console.WriteLine("The year {0} is NOT a Leap Year",userInput);
            }
            Console.WriteLine("Press any key to continue or press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if(keyChar=='0')Environment.Exit(0);
        }
    }
}