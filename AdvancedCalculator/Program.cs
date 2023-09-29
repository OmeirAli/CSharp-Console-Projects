using System;
using System.Net.NetworkInformation;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                int n = GetNumberOfInputs();
                double[] inputNumbers = GetInputNumbers(n);
                int operation = GetOperations();
                bool reverseOrder = GetReverseOrder(operation);
                switch (operation)
                {
                    case 1: PerformAddition(inputNumbers);
                        break;
                    case 2: PerformSubtraction(inputNumbers, reverseOrder);
                        break;
                    case 3: PerformMultiplication(inputNumbers);
                        break;
                    case 4: PerformDivision(inputNumbers, reverseOrder);
                        break;
                    case 5: PerformAllOperations(inputNumbers, reverseOrder);
                        break;
                }
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        static int GetNumberOfInputs()
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

                if (!int.TryParse(userInput, out int n) ||  n <= 0)
                {
                    Console.WriteLine("Error! Input can only be a positive integer!");
                    continue;
                }
                return n;
            }
        }

        static double[] GetInputNumbers(int n)
        {
            
            double[] inputNumbers = new double [n];
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
                    Console.WriteLine("Error! Input can only be a number!");
                    i--;
                }
                else
                {
                    inputNumbers[i] = tempOutput;
                }
            }

            return inputNumbers;

        }

        static int GetOperations()
        {
            while (true)
            {
                Console.Write("Select Operation\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. All Of The Above\nYour Selection: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }

                if (int.TryParse(userInput, out int operation) && operation >= 1 && operation <= 5)
                {
                    return operation;
                }
                Console.WriteLine("Invalid Input! Only input between number 1 to 5 is accepted!");
            }
        }

        static bool GetReverseOrder(int operation)
        {
            if (operation == 2 || operation == 4 || operation == 5)
            {
                while (true)
                {
                    Console.Write("Would you like to reverse the order of operations? Press 1 for YES or Press 2 for NO: ");
                    string userInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("Error! Input cannot be blank!");
                        continue;
                    }

                    if (!int.TryParse(userInput, out int userChoice))
                    {
                        Console.WriteLine("Error! Input can only be a number of 1 or 2!");
                        continue;
                    }

                    if (userChoice == 1)
                    {
                        return true;
                    }

                    if (userChoice == 2)
                    {
                        return false;
                    }
                    Console.WriteLine("Invalid Input! Please enter valid option!");
                }

            }
            
            return false;
        }

        static void PerformAddition(double[] inputNumbers)
        {
            double result = inputNumbers[0];
            for (int i = 1; i < inputNumbers.Length; i++)
            {
                result += inputNumbers[i];
            }
            Console.WriteLine("Addition: The Addition of {0} is: {1}", string.Join(", ", inputNumbers), result);
        }

        static void PerformSubtraction(double[] inputNumbers, bool reverseOrder)
        {
            double result;
            if (reverseOrder)
            {
                result = inputNumbers[inputNumbers.Length - 1];
                for (int i = inputNumbers.Length - 2; i >= 0; i--)
                {
                    result -= inputNumbers[i];
                }
            }
            else
            {
                result = inputNumbers[0];
                for (int i = 1; i < inputNumbers.Length; i++)
                {
                    result -= inputNumbers[i];
                }
            }
            Console.WriteLine("Subtraction: The Subtraction of {0} is: {1}", string.Join(", ", inputNumbers), result);
        }
        
        static void PerformMultiplication(double[] inputNumbers)
        {
            double result = inputNumbers[0];
            for (int i = 1; i < inputNumbers.Length; i++)
            {
                result *= inputNumbers[i];
            }
            Console.WriteLine("Multiplication: The Multiplication of {0} is: {1}", string.Join(", ", inputNumbers), result);
        }

        static void PerformDivision(double[] inputNumbers, bool reverseOrder)
        {
            double result;
            if (reverseOrder)
            {
                result = inputNumbers[inputNumbers.Length - 1];
                for (int i = inputNumbers.Length - 2; i >= 0; i--)
                {
                    if (inputNumbers[i] == 0)
                    {
                        Console.WriteLine("Quotient: Error! Cannot divide by zero!");
                        return;
                    }
                    
                    result /= inputNumbers[i];

                }
            }
            else
            {
                result = inputNumbers[0];
                for (int i = 1; i < inputNumbers.Length; i++)
                {
                    if (inputNumbers[i] == 0)
                    {
                        Console.WriteLine("Quotient: Error! Cannot divide by zero!");
                        return;
                    }
                    result /= inputNumbers[i];
                }
            }
            Console.WriteLine("Division: The Quotient of {0} is: {1}", string.Join(", ", inputNumbers), result);
        }

        static void PerformAllOperations(double[] inputNumbers, bool reverseOrder)
        {
            PerformAddition(inputNumbers);
            PerformSubtraction(inputNumbers, reverseOrder);
            PerformMultiplication(inputNumbers);
            PerformDivision(inputNumbers, reverseOrder);
            
        }
        
    }
}