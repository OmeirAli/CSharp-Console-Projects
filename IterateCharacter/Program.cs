//iterate through each character of a string, print the result.
using System.Text;
namespace IterateCharacter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                GetCharacter();
                Console.WriteLine("Press any key to continue or press 0 to quit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        private static void GetCharacter()
        {
            while (true)
            {
                Console.Write("Please enter a string: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                }
                else if (double.TryParse(userInput, out double n))
                {
                    Console.WriteLine("Error! Input cannot be a numerical value!");
                }
                else
                {
                    Console.WriteLine("The input is: {0}", userInput);
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in userInput)
                    {
                        sb.Append(c);
                        if (c != userInput[userInput.Length - 1])
                        {
                            sb.Append(", ");
                        }
                    }
                    Console.WriteLine(sb.ToString());
                }
            }
        }
    }
}