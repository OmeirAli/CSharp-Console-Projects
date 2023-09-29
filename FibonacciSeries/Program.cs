using System;
namespace FibonacciSeries;

class Program
{
    static void Main()
    {
        string termInput;
        int termOutput;
        while (true)
        {
            do
            {
                Console.Write("Please enter number of terms: ");
                termInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(termInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    continue;
                }
                if (!int.TryParse(termInput, out termOutput) || termOutput < 1)
                {
                    Console.WriteLine("Error! Whole numbers input greater than zero accepted only!");
                }
                
            } while (string.IsNullOrWhiteSpace(termInput)||!int.TryParse(termInput, out termOutput) || termOutput < 1);

            int t1 = 0;
            int t2 = 1;
            int sum;
            for (int i = 0; i < termOutput; i++)
            {
                Console.WriteLine("Term " + (i+1) + ": "+ t1);
                sum = t1 + t2;
                t1 = t2;
                t2 = sum;
            }
            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if(keyChar == '0')Environment.Exit(0);
        }
    }
}