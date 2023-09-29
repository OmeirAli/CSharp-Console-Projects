using System;

namespace HCF
{
    class Program
    {
        static void Main()
        {
            string userInput;
            int n; //total number of convoys
            int tempOutput; //total number of vehicles
            
            while (true)
            {
                do
                {
                    Console.Write("Enter the number of drone fleets: ");
                    userInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("Input cannot be blank!");
                        continue;
                    }

                    if (!int.TryParse(userInput, out n) || n < 2)
                    {
                        Console.WriteLine("Error! Accepted input is whole numbers greater than 2!");
                    }
                } while (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out n) || n < 2);
                
                int[] numberInput = new int[n];
                for (int i = 0; i < n; i++)
                {   
                    Console.WriteLine("Enter drone number for fleet " + (i + 1) + ": ");
                    userInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("Input cannot be blank!");
                        i--;
                    }
                    else if (!int.TryParse(userInput, out tempOutput) || tempOutput < 2)
                    {
                        Console.WriteLine("Error! Accepted input is whole numbers greater than 2!");
                        i--;
                    }
                    else
                    {
                        numberInput[i] = tempOutput;
                    }
                }

                long num1 = numberInput[0];
                for (int i = 1; i < n; i++)
                {
                    long num2 = numberInput[i];
                    long result;
                    while (num2 != 0)
                    {
                        result = num1 % num2;
                        num1 = num2;
                        num2 = result;
                    }
                    long HCF2 = num1;
                    long LCM = num1 * numberInput[i] / HCF2;
                    num1 = LCM;
                }
                Console.WriteLine("The highest capacity that wormholes can handle without causing an interstellar incident: {0}", HCF);
                Console.WriteLine("The number of drones that can be dispatched for future missions: {0}", LCM);
                Console.WriteLine("Press any key to continue or press '0' to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }
    }
}
