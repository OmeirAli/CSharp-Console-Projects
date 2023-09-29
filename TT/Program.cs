using System;

namespace TT
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {   
                Console.WriteLine("Welcome to Times Table Calculator! ");
                int? baseValue = GetInput("Enter the base value or type 'exit' to quit the program: ");
                if (!baseValue.HasValue) return;
                int? multiplierValue = GetInput("Enter the multiplier value or type 'exit' to quit the program: ");
                if (!multiplierValue.HasValue) return;
                PrintTimesTable(baseValue.Value, multiplierValue.Value);
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        static int? GetInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit") return null;
                
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }

                if (!int.TryParse(userInput, out int value) || value < 0)
                {
                    Console.WriteLine("Error! Only positive integer is accepted as input");
                    continue;
                }
                return value;
            }
        }

        static void PrintTimesTable(int baseValue , int multiplierValue)
        {
            for (int i = 0; i <= multiplierValue; i++)
            {
                int result = baseValue * i;
                Console.WriteLine("{0} x {1} = {2}", baseValue, i, result );
            }
        }
    }
}