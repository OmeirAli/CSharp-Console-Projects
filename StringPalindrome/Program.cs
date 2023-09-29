using System;

namespace StringPalindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                GetPalindrome();
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        private static void GetPalindrome()
        {
            while (true)
            {
                Console.Write("Enter a string value: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                   
                }

                else if (double.TryParse(userInput, out double n))
                {
                    Console.WriteLine("Error! Numerical values are NOT accepted!");
                    
                }
                else
                {
                    Console.WriteLine("Your entered string value is: {0}", userInput);
                    string reverse = "";
                    for (int i = userInput.Length - 1; i >= 0; i--)
                    {
                        reverse += userInput[i];
                    }
                    if (userInput == reverse)
                    {
                        Console.WriteLine("{0} equals {1} and therefore \"{2}\" is a Palindrome", userInput, reverse, userInput);
                    }
                    else
                    {
                        Console.WriteLine("{0} does NOT equal {1} and therefore \"{2}\" is NOT a Palindrome", userInput, reverse, userInput);
                    }
                }
            }
        }
    }
}