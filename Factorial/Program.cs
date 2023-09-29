using System;
using System.Numerics;
namespace Factorial;

class Program
{
    static void Main()
    {
        string userPlayerInput;
        int parsedPlayerOutput;
        while (true)
        {
            do
            {
               Console.Write("Enter the number of players for your team: ");
               userPlayerInput = Console.ReadLine();
               if (string.IsNullOrWhiteSpace(userPlayerInput))
               {
                   Console.WriteLine("Input cannot be blank!");
                   continue;
               }

               if (!int.TryParse(userPlayerInput, out parsedPlayerOutput)|| parsedPlayerOutput < 0)
               {
                   Console.WriteLine("Error! Only positive whole numbers are accepted!");
               }
            } while (string.IsNullOrWhiteSpace(userPlayerInput) || !int.TryParse(userPlayerInput, out parsedPlayerOutput) || parsedPlayerOutput < 0);

            BigInteger factorial;
            if (parsedPlayerOutput == 0)
            {
                factorial = 1;
            }
            else
            {
                factorial = parsedPlayerOutput;
                for (BigInteger i = factorial - 1; i >= 1; i--)
                {
                    factorial *= i;
                }
                
            }
            Console.WriteLine("The number of times the players of {0} can be arranged is: {1}", parsedPlayerOutput,factorial);
            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0') break;
        }
    }
}