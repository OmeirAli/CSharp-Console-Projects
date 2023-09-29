using System;
namespace VC;

class Program
{
    static void Main()
    {
        string userInput;
        while (true)
        {
            bool isLettersOrSpaces = false;
            while (!isLettersOrSpaces)
            {
                isLettersOrSpaces = true;
                int vowel = 0;
                int consonant = 0;
                Console.Write("Enter a sentence: ");
                userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                }
                else
                {
                    isLettersOrSpaces = true;
                    foreach (char c in userInput)
                    {
                        if (!Char.IsLetter(c) && c!= ' ')
                        {
                            isLettersOrSpaces = false;
                            Console.WriteLine("Error! Input can only be a string of letters and spaces!");
                            break;
                        }
                        else if (Char.IsLetter(c))
                        {
                            if (c == 'a' || c == 'e'|| c == 'i' || c == 'o'|| c == 'u' || c == 'A' || c == 'E'|| c == 'I' || c == 'O'|| c == 'U')
                            {
                                vowel++;
                            }
                            else
                            {
                                consonant++;
                            }
                        }
                    }
                    if (isLettersOrSpaces)
                    {
                        Console.WriteLine("You entered: {0}", userInput);
                        Console.WriteLine("Number of Category A (Vowels): {0}", vowel);
                        Console.WriteLine("Number of Category B (Consonants): {0}", consonant);
                    }
                }
            }
            Console.WriteLine("Press any key to con+nue or press 0 to exit: ");
            char keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar == '0' ) break;

        }
    }
}