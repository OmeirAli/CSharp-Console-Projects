using System;

namespace CompareTwoString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                GetCompare();
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        private static string GetStringInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }
                if (double.TryParse(userInput, out double n))
                {
                    Console.WriteLine("Error! Input cannot be numerical value!");
                    continue;
                }

                return userInput;
            }
        }

        private static void GetCompare()
        {
            string string1 = GetStringInput("Please enter the first string: ");
            string string2 = GetStringInput("Please enter the second string: ");

            Console.WriteLine("The entered input of string1 is \"{0}\" and string 2 is \"{1}\" ", string1, string2);
            if (string1 == string2)
            {
                Console.WriteLine("{0} is equal to {1}", string1, string2);
            }
            else
            {
                Console.WriteLine("{0} is NOT equal to {1}", string1, string2);
            }
        }
    }
}