using System;

namespace StandardDeviation
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int n = GetNumberOfInputs(); //getting number of user inputs
                double[] inputNumbers = GetInputNumbers(n);
                GetSdFormula(inputNumbers);
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

               if (!int.TryParse(userInput, out int n) || n<= 0)
               {
                   Console.WriteLine("Error! Input of positive integer is only accepted!");
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
                Console.WriteLine($"Enter number {i + 1}: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    i--;
                }
                else if (!double.TryParse(userInput, out double tempOutput))
                {
                    Console.WriteLine("Error! Input can only be a number!");
                }
                else
                {
                    inputNumbers[i] = tempOutput;
                }
            }
            return inputNumbers;
        }

        private static void GetSdFormula(double[] inputNumbers)
        {
            double sum = 0.0;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                sum += inputNumbers[i];
            }
            double mean = sum / inputNumbers.Length;
            double squareOfNumbers = 0.0;
            for (int i = 0; i < inputNumbers.Length; i++)
            {       
                squareOfNumbers += Math.Pow((inputNumbers[i] - mean), 2);
            }

            double variance = squareOfNumbers / inputNumbers.Length;
            double sdResult = Math.Sqrt(variance);
            Console.WriteLine("The standard deviation of {0} is: {1}", string.Join(", ", inputNumbers), sdResult);
        }
    }
}