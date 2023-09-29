using System;

class Program
{
    static void Main()
    {
        string userInput;
        int sideLength;
        while (true)
        {
            do
            {
                Console.Write("Enter the side length of the square: ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be blank!");
                    continue;
                }

                if (!int.TryParse(userInput, out sideLength) || sideLength <= 0)
                {
                    Console.WriteLine("Error! Accepted input is a whole number greater than 0!");
                }
            } while (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out sideLength) || sideLength <= 0);

            int area = sideLength * sideLength;
            Console.WriteLine("The area of the square with side length {0} is: {1}", sideLength, area);

            Console.WriteLine("Press any key to continue or press 0 to quit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0') break;
        }
    }
}