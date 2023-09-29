
//Write a program to Calculate the Area of a Square in C#.The program needs to further meet two conditions:
// 1) The program needs to handle all exceptions.
// 2) The user has an option to restart the program and quit the program.


using System;

namespace AreaOfSquare;

class Program
{

    static void Main(string[] args)
    {
        double SideValue;

        while (true)
        {

            while (true)

            {
                try
                {

                    Console.WriteLine("Enter side value of square: ");
                    SideValue = double.Parse(Console.ReadLine());
                    break;

                }

                catch (FormatException)
                {
                    Console.WriteLine("Please enter numerical values only: ");
                }

            }

            double AreaOfSquare = Math.Pow(SideValue, 2);
            Console.WriteLine("The total Area of the Square is: " + AreaOfSquare + "units\u00B2");
            Console.WriteLine("Press any key to calculate area of another squre or press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0') Environment.Exit(0);

        }
    }

}