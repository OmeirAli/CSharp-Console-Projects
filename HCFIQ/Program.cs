using System;
using System.IO.Compression;

namespace HCFIQ;

class Program
{
    static void Main()
    {
        string userInput;
        int n;//total number of convoy's
        int tempOutput; //total number of vehicles
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
            
            
            int[] numberInput = new int[n];
            for (int i = 0; i < n; i++)
            {   
                Console.WriteLine("Enter Vehicles for convoy " + (i + 1) + ": ");
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

            int num1 = numberInput[0];
            for (int i = 1; i < n; i++)
            {
                int num2 = numberInput[i];
                int result;
                while (num2 != 0)
                {
                    result = num1 % num2;
                    num1 = num2;
                    num2 = result;
                    Console.WriteLine("The highest LCM {0}", result);
                    
                    

                    //2 convoys: num1 = 48, num2=18,result = 48/18= 2.666667, 2.666667-2=0.666667*18=12
                    //48,18,12
                    //num1 = 18
                    //num2 =12
                    //result 18%12 = 6
                    //48,18,12,6,0
                    //num1=6 num2=0 result=UDF
                }
            }

            int HCF = num1;
            Console.WriteLine("The HCF for the number of vehicles per convoy where the total number of convoys can safely travel across the bridge without overloading is: {0}",HCF);
            Console.WriteLine("Press any key to continue of press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0') break;
        }
    }
}