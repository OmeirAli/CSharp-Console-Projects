//Write a Program to Swap Numbers with second variable in C#. Program must handle all exceptions.

using System;

namespace SwapNumber;

class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;

        while (true)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("num1 original value= " + num1);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numerical value only for num1!");
                }
                
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("num2 original value= " + num2);
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numerical value only for num2!");
                }
                
            }

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("num1 swapped value= " + num1);
            Console.WriteLine("num2 swapped value= " + num2);
            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if(keyChar == '0')Environment.Exit(0);

        }
    }
}