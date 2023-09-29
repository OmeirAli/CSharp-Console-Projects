using System;
namespace IDFO;

class Program
{
    static void Main()
    {
        int n; //number of fleets
        string userInput;
        int tempOutput;
        while (true)
        {
            do
            {
                Console.Write("Enter the number of fleets: ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    continue;
                }

                if (!int.TryParse(userInput, out n) || n < 2)
                {
                    Console.WriteLine("Error! Accepted input is whole numbers only greater than 1!");
                }
            } while (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out n) || n < 2);

            int[] numberInput = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the number of drones for fleet" + (i+1) + ": ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    i--;
                }
                else if (!int.TryParse(userInput, out tempOutput) || tempOutput < 2)
                {
                    Console.WriteLine("Error! Accepted input is whole numbers only greater than 1!");
                    i--;
                }
                else
                {
                    numberInput[i] = tempOutput;
                }
            }

            int HCF = numberInput[0];
            for (int i = 1; i < n; i++)
            {
                int num1 = HCF;
                int num2 = numberInput[i];
                while (num2 != 0)
                {
                    int result = num1 % num2;
                    num1 = num2;
                    num2 = result;
                }

                HCF = num1;
            }
            int LCM = numberInput[0];
            for (int i = 1; i < n; i++)
            {
                int num1 = LCM;
                int num2 = numberInput[i];
                while (num2 != 0)
                {
                    int result = num1 % num2;
                    num1 = num2;
                    num2 = result;
                }

                LCM = LCM * numberInput[i] / num1;
            }
            Console.WriteLine("Maximum attribute common/shared to all fleet sizes: {0}",HCF);
            Console.WriteLine("Minimum Universal Dispatcher divisible by all fleets: {0}",LCM);
            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0') break;


        }
    }
}