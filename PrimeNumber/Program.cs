using System;
namespace PrimeNumber;

class Program
{
    static void Main()
    {
        string userInput;
        int n; //converted userinput to int output
        while (true)
        {
            int counter = 0;
            do
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank");
                    continue;
                }

                if (!int.TryParse(userInput, out n) || n < 0)
                {
                    Console.WriteLine("Error! Input can only be a positive number!");
                }
            } while (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out n) || n < 0);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                Console.WriteLine("{0} possesses the enigmatic mathematical characteristic", n);
            }
            else
            {
                Console.WriteLine("{0} does not posses the enigmatic mathematical characteristic", n);
            }
            Console.WriteLine("Press any key to continue or press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if(keyChar == '0')break;
        }
    }
}