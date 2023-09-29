
using System;
namespace ArmStrongNumber;

class Program
{
    static void Main()
    {
        string userInput;
        int number;
        int rem;
        int originalNumber = 0;
        while (true)
        {
            int resultSum = 0;
            int counter = 0;

            do
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }
                if (!int.TryParse(userInput, out number) || number < 0)
                {
                    Console.WriteLine("Error! Only positive whole number is accepted!");
                }
                else
                {
                    originalNumber = number;
                }

            } while (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out number) || number < 0);
            
            //Calculate number of digits from user input;
            while (originalNumber != 0)
            {
                originalNumber /= 10;
                counter++;
            }

            originalNumber = number;
            
            //Armstrong calculation;
            while (originalNumber != 0)
            {
                rem = originalNumber % 10;
                resultSum += (int)Math.Pow(rem, counter);
                originalNumber /= 10;
            }

            if (resultSum == number)
            {
                Console.WriteLine("{0} is an Armstrong number.",number);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.",number);
            }
            Console.WriteLine("Press any key to continue or press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0') break;
        }
        
    }
}