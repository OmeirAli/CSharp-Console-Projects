using System;
namespace LargestElementArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int n = GetNumberOfInputs();
                double[] inputNumbers = GetInputNumbers(n);
                GetLargestElement(inputNumbers);
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
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
                Console.Write($"Enter number {i + 1}: ");
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
                    inputNumbers[i] = tempOutput;
                }
            }
            return inputNumbers;
        }

        private static void GetLargestElement(double[] inputNumbers)
        {   
            double largestElement = inputNumbers[0];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] > largestElement)
                {
                    largestElement = inputNumbers[i];
                }
            }
            Console.WriteLine("The average elements of the array of {0} is: {1}", string.Join(", ",inputNumbers), largestElement);
        }
        
    }
}
        