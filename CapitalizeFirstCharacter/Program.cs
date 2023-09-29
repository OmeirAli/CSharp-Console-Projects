using System;

namespace CapitalizeFirstCharacter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                GetResult();
                
            }
        }
        private static void GetResult()
        {
            while (true)
            {
                Console.Write("Please enter a word: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                }
                else if (double.TryParse(userInput, out double n))
                {
                    Console.WriteLine("Error! Numerical value is NOT accepted!");
                }
                else if (!ContainsOnlyLetters(userInput))
                {
                    Console.WriteLine("Error! Please enter only alphabetic characters!");
                }
                else
                {
                    string capitalized = ToTitleCase(userInput);
                    Console.WriteLine("Capitalization of the first letter of the word {0} is: {1}",userInput,capitalized);
                }
            }
        }

        private static bool ContainsOnlyLetters(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private static string ToTitleCase(string userInput)
        {
            string[] words = userInput.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0) continue;

                char firstLetter = char.ToUpper(words[i][0]);
                string restOfWord = words[i].Substring(1).ToLower();

                words[i] = firstLetter + restOfWord;
            }

            return string.Join(" ", words);
        }

    }
}