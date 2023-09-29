using System;
namespace PalindromeDataStream;

class Program
{
    static void Main()
    {
        string userInput;
        int n;
        while (true)
        {
            do
            {
                Console.Write("Enter the data stream as a number: ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    continue;
                }

                if (!int.TryParse(userInput, out n) || n < 0 )
                {
                    Console.WriteLine("Error! Accepted input can only be whole number greater than 0!");
                }
            } while (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out n) || n < 0);

            int reversed = 0;
            int remainder;
            int input = n;
            while (n > 0)
            {
                remainder = n % 10;
                reversed = (reversed * 10) + remainder;
                n /= 10;
            }

            if (reversed == input)
            {
                Console.WriteLine("The data stream input of {0} exhibits symmetry", input);
            }
            else
            {
                Console.WriteLine("The data stream input of {0} exhibits asymmetry/no symmetry", input);
            }
            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0') break;
        }
    }
}