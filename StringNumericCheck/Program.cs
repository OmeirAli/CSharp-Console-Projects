namespace StringNumericCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string userInput = GetUserInput();
                
                Console.WriteLine("Press any key to continue or press 0 to quit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
        }

        private static string GetUserInput()
        {
            while (true)
            {
                Console.Write("Please enter a value: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank");
                }
                else if (double.TryParse(userInput, out double n))
                {
                    Console.WriteLine("The entered input \"{0}\" is a numeric value", userInput);
                    return userInput;
                }
                else
                {
                    Console.WriteLine("The entered input \"{0}\" is a string value", userInput);

                    return userInput;
                }
            }
        }
    }
}