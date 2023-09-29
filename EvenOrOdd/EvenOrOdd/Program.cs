//Write a Program to Check if a Number Is Even or Odd in C#. Make sure all exceptions are handled.
//This is a voiceless recording video with facecam.

using System;

namespace EvenOrOdd;

class Program
{
    static void Main()
    {
        string UserStringInput;
        int UserOutNumber;

        while (true)
        {
            do
            {
               Console.Write("Please enter a number: ");
               UserStringInput = Console.ReadLine();
               if (string.IsNullOrWhiteSpace(UserStringInput))
               {
                   Console.WriteLine("Input cannot be blank!");
                   continue;
               }

               if (!int.TryParse(UserStringInput, out UserOutNumber))
               {
                   Console.WriteLine("Error! Accepted input is whole numbers only!");
               }
               
            } while (string.IsNullOrWhiteSpace(UserStringInput) || !int.TryParse(UserStringInput, out UserOutNumber));

            if (UserOutNumber % 2 == 0)
            {
                Console.WriteLine("{0} is even", UserStringInput);
            }
            else
            {
                Console.WriteLine("{0} is odd", UserStringInput);
            }
            Console.WriteLine("Press any key to continue or press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if(keyChar == '0')Environment.Exit(0);
        }
    }
}

