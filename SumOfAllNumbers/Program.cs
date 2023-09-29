//Write a program in C# to Calculate the Sum of all digits of a number. Make sure all exceptions are handled

using System;

namespace SumOfAllNumbers
{

    class Program
    {
        static void Main()
        {
            int digit;

            while (true)
            {
                string input;
                int sum = 0;
                while (true)
                {

                    try
                    {
                        Console.WriteLine("Please input a number: ");
                        input = Console.ReadLine();
                        for (int i = 0; i < input.Length; i++)
                        {
                            digit = int.Parse(input[i].ToString());
                            sum += digit;

                        }

                        break;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Please input whole numbers only!");
                    }

                }

                Console.WriteLine("Total sum of " + input + " = " + sum);
                Console.WriteLine("Press any key to continue or press 0 to quit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') Environment.Exit(0);
            }
        }
    }
}