//Write a C# Program to check whether an alphabet is a vowel or a consonant. Make sure all exceptions are handled.

using System;
namespace VowelOrConstant;

class Program
{
    static void Main()
    {
        while (true)
        {
           Console.Write("Please enter a letter: ");
           string UserInput = Console.ReadLine();
           if (string.IsNullOrWhiteSpace(UserInput) || UserInput.Length > 1 || !char.IsLetter(UserInput[0]))
           {
            Console.WriteLine("{0} is invalid!",UserInput);
            continue;
           }

           char character = UserInput[0];
           bool isVowel = (character == 'a' || character == 'e' || character == 'i' || character == 'o' ||
                           character == 'u');
           if (isVowel)
           {
               Console.WriteLine("{0} is a vowel", UserInput);
           }
           else
           {
               Console.WriteLine("{0} is a consonant", UserInput);
           }
           Console.WriteLine("Press any key to continue or press 0 to quit: ");
           char keyChar = Console.ReadKey(true).KeyChar;
           if(keyChar == '0')Environment.Exit(0);
           
        }
    }
}