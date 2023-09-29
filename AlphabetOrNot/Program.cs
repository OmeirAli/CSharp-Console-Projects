//Write a C# Program to Check whether a Character Is Alphabet or Not. Handle all exceptions:

using System;
namespace AlphabetOrNot;

class Program
{
    static void Main()
    {
        string UserInput;
        while (true)
        {
            while (true)
            {
                Console.WriteLine("Please enter your character in letter format: ");
                UserInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(UserInput))
                {
                    Console.WriteLine("The input cannot be blank!");
                }
                else
                {
                    char character;
                    bool isChar = char.TryParse(UserInput, out character);
                    bool isLetter = (character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z');
                    if (isChar && isLetter) 
                    {
                        Console.WriteLine("{0} is a valid character in letter format", UserInput);
                    }
                    else
                    {
                        Console.WriteLine("{0} is NOT a valid character in letter format", UserInput);
                        break;
                    }
                }
            }
            Console.WriteLine("Press any key to continue or press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if(keyChar == '0')Environment.Exit(0);
        }
    }
}