using System;

namespace HCFLCM
{
    class Program
    {
        static void Main()
        {
            string userInput;
            int n; // total number of convoys
            int tempOutput; // total number of vehicles

            while (true)
            {
                do
                {
                    Console.Write("Enter the number of convoys: ");
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

                long[] numberInput = new long[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter the number of vehicles for convoy " + (i + 1) + ": ");
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

                // Calculate HCF for all numbers
                long HCF = numberInput[0];
                for (int i = 1; i < n; i++)
                {
                    long num1 = HCF;
                    long num2 = numberInput[i];

                    while (num2 != 0)
                    {
                        long result = num1 % num2;
                        num1 = num2;
                        num2 = result;
                    }
                    HCF = num1;
                }

                // Calculate LCM using the correct LCM formula
                long LCM = numberInput[0];
                for (int i = 1; i < n; i++)
                {
                    long num1 = LCM;
                    long num2 = numberInput[i];

                    // Calculate HCF of num1 and num2 for LCM computation
                    while (num2 != 0)
                    {
                        long result = num1 % num2;
                        num1 = num2;
                        num2 = result;
                    }

                    LCM = LCM * numberInput[i] / num1;
                }


                Console.WriteLine("The HCF for the number of vehicles per convoy where the total number of convoys can safely travel across the bridge without overloading is: {0}", HCF);
                Console.WriteLine("The LCM for the number of vehicles per convoy where the total number of convoys can safely travel across the bridge without overloading is: {0}", LCM);
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }
    }
}
