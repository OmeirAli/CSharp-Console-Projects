//Write a C# Program to Find the Largest Number among the Four Numbers. Make sure all exceptions are handled

using System;

namespace FindLargestNumber;

class Program
{
    static void Main()
    {
        double tempOutput;
        while (true)
        {   
            string[]numberNames={"first","second","third","fourth"};
            double[] inputCount = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Please enter {0} number: ", numberNames[i]);
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    i--;
                }
                else if (!double.TryParse(userInput, out tempOutput))
                {
                    Console.WriteLine("Error! Accepted input is numbers only!");
                    i--;
                }
                else
                {
                    inputCount[i] = tempOutput;
                }
            }

            double LargestNumber = inputCount[0];
            for (int i = 1; i < inputCount.Length; i++)
            {
                if (inputCount[i] > LargestNumber)
                {
                    LargestNumber = inputCount[i];
                }
            }
            Console.WriteLine("The largest number is: {0}",LargestNumber);
            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if(keyChar == '0')Environment.Exit(0);
        }
    }
}

