using System;
using System.Text;

namespace TextAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter any words or a sentence with spaces: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank");
                    continue;
                }

                if (!ContainsOnlyLetters(userInput))
                {
                    Console.WriteLine("Error! Only alphabetical values are accepted!");
                    continue;
                }
                GetCharacter(userInput);
                GetPalindrome(userInput);
                GetCapital(userInput);
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        private static void GetCharacter(string userInput)
        {
            Console.WriteLine("The input is: {0}", userInput);
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (char c in userInput)
            {
                sb.Append(c);
                if (count != userInput.Length - 1)
                {
                    sb.Append(", ");
                }
                count++;
            }
            Console.WriteLine(sb.ToString());
        }

        private static void GetPalindrome(string userInput)
        {
            string reverse = "";
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reverse += userInput[i]; 
            }

            if (userInput.Replace(" ","").ToLower() == reverse.Replace(" ","").ToLower() )
            {
                Console.WriteLine("{0} is equal to {1}, hence, {2} is a palindrome", userInput, reverse, userInput);
            }
            else
            {
                Console.WriteLine("{0} is NOT equal to {1}, hence, {2} is NOT a palindrome", userInput, reverse, userInput);
            }
        }

        private static void GetCapital(string userInput)
        {
            string[] words = userInput.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == '0') continue;
                char firstLetter = char.ToUpper(words[i][0]);
                string restLetters = words[i].Substring(1).ToLower();
                words[i] = firstLetter + restLetters;
            }

            string capitalized = string.Join(" ", words);
            Console.WriteLine("The capitalization of the first letter of the word {0} is: {1}", userInput, capitalized);
        }

        private static bool ContainsOnlyLetters(string userInput)
        {
            foreach (char c in userInput)
            {
                if (!char.IsLetter(c) && c!= ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}