using System;

namespace ArrayNumberCheck
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                int n = GetNumberOfInputs();
                double[] inputNumbers = GetInputNumbers(n);
                bool numberCheck = GetNumberCheck(inputNumbers);
                Console.WriteLine("Press any key to continue or press 0 to quit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        private static int GetNumberOfInputs()
        {
            while (true)
            {
                Console.Write("How many numbers would you like to enter?: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }
                if (!int.TryParse(userInput, out int n) || n <= 0)
                {
                    Console.WriteLine("Error! Input can only be a positive integer!");
                    continue;
                }
                return n;
            }
        }
        private static double[] GetInputNumbers(int n)
        {
            double[] inputNumbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the number {i + 1}: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    i--;
                }
                else if (!double.TryParse(userInput, out double tempOutput))
                {
                    Console.WriteLine("Error! Input can only be a numerical value!");
                    i--;
                }
                else
                {
                    if (tempOutput == -0)
                    {
                        tempOutput = 0;
                    }
                    inputNumbers[i] = tempOutput;
                }
            }
            return inputNumbers;
        }

        private static bool GetNumberCheck(double[] inputNumbers)
        {
            while (true)
            {
                Console.Write("Enter a number to check if it exists in the array: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }

                if (!double.TryParse(userInput, out double numberToCheck))
                {
                    Console.WriteLine("Error! Input can only be a numerical value!");
                    continue;
                }

                // Check if number exists in the array
                foreach (double number in inputNumbers)
                {
                    if (number == numberToCheck)
                    {
                        Console.WriteLine($"Number {numberToCheck} exists in the array.");
                        return true;
                    }
                }
                Console.WriteLine($"Number {numberToCheck} does not exist in the array.");
                return false;
            }
        }

        
    }
}