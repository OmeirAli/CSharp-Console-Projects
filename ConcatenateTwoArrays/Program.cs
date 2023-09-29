using System;
using System.Linq;

namespace ConcantenateTwoArrays
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                int size1 = GetNumberOfInputs(1);
                int size2 = GetNumberOfInputs(2);
                double[] inputNumbers1 = GetInputNumbers(1, size1);
                double[] inputNumbers2 = GetInputNumbers(2, size2);
                ConcatenateTwoArrays(inputNumbers1, inputNumbers2);
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        private static int GetNumberOfInputs(int arrayNumber)
        {
            while (true)
            {
                Console.Write($"How many numbers would you like to enter for Array {arrayNumber}?: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }

                if (!int.TryParse(userInput, out int size) || size <= 0 )
                {
                    Console.WriteLine("Error! Input can only be a positive integer!");
                    continue;
                }

                return size;
            }
        }

        private static double[] GetInputNumbers(int arrayNumber, int size)
        {
            Console.Write("\n");
            double[] inputNumbers = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Array {arrayNumber}: Enter number {i + 1}: ");
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
                    if (tempOutput == -0)  // Check for -0 here
                    {
                        tempOutput = 0;
                    }
                    inputNumbers[i] = tempOutput;
                }
            }

            return inputNumbers;
        }
        private static void ConcatenateTwoArrays(double[] inputNumbers1, double[] inputNumbers2)
        {
            double[] result = inputNumbers1.Concat(inputNumbers2).ToArray();
            Console.WriteLine("The concatenation of Array 1 and Array 2 results as: {0}", string.Join(", ", result));
        }
    }
}
