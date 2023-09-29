using System;
using System.Data;

namespace Pattern
{
    class Program
    {
        static string[] patterns = new string[]
        {
            "Right Triangle Star Pattern",
            "Left Triangle Star Pattern",
            "Pyramid Star Pattern",
            "Diamond Star Pattern",
            "Right Triangle Number Pattern",
            "Right Triangle Repeat Number Pattern",
            "Pyramid Number Pattern (Asc)",
            "Pyramid Number Pattern (Desc)",
            "Pyramid Repeat Number Pattern",
            "Diamond Alphabet Pattern Way 1",
            "Diamond Alphabet Pattern Way 2"
        };

        static void Main(string[] args)
        {
            while (true)
            {
                int userChoice = GetUserChoice();
                int rowInput = GetRowInput(userChoice);

                switch (userChoice)
                {
                    case 1:
                        RightTriangleStar(rowInput);
                        break;
                    case 2:
                        LeftTriangleStar(rowInput);
                        break;
                    case 3:
                        PyramidStar(rowInput);
                        break;
                    case 4:
                        DiamondStar(rowInput);
                        break;
                    case 5:
                        RightAngleNumber(rowInput);
                        break;
                    case 6:
                        RightAngleNumberRepeat(rowInput);
                        break;
                    case 7:
                        PyramidAscending(rowInput);
                        break;
                    case 8:
                        PyramidDescending(rowInput);
                        break;
                    case 9:
                        PyramidRepeat(rowInput);
                        break;
                    case 10:
                        DiamondAlphabetWay1(rowInput);
                        break;
                    case 11:
                        DiamondAlphabetWay2(rowInput);
                        break;
                }
                Console.WriteLine("Press any key to continue or press 0 to exit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '0') break;
            }
            
        }
        
        static int GetUserChoice()
        {
            while (true)
            {
                for (int i = 0; i < patterns.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {patterns[i]}");
                }
                Console.Write("Please enter a number from the list below to choose your pattern: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }
                if (!int.TryParse(userInput, out int userChoice) || userChoice < 1 || userChoice > patterns.Length)
                {
                    Console.WriteLine("Error! Please only enter a number between 1 and {0}!", patterns.Length);
                    continue;
                }
                Console.WriteLine("You've selected: {0}", patterns[userChoice - 1]);
                return userChoice;
            }
        }
        
        static int GetRowInput(int userChoice)
        {
            while (true)
            {
                Console.Write("Please enter the number of rows you want for {0}: ", patterns[userChoice - 1]);
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error! Input cannot be blank!");
                    continue;
                }
                if (!int.TryParse(userInput, out int rowInput) || rowInput < 1)
                {
                    Console.WriteLine("Error! Only a positive whole number is accepted!");
                    continue;
                }
                return rowInput;
            }
        }

        static void RightTriangleStar(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void LeftTriangleStar(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int space = 1; space <= rowInput - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        static void PyramidStar(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int space = i; space <= rowInput; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void DiamondStar(int rowInput)
        {
            
            for (int i = 1; i < rowInput; i++)
            {
                for (int space = i; space <= rowInput; space++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{"*",2}");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{"*",2}");
                }
                Console.WriteLine();
                
            }

            
            for (int i = 1; i <= rowInput; i++)
            {
                for (int space = 1; space <= i; space++)
                {
                    Console.Write("  ");
                }

                for (int j = i; j < rowInput; j++)
                {
                    Console.Write($"{"*",2}");
                }
                for (int k = i; k <= rowInput; k++)
                {
                    Console.Write($"{"*",2}");
                }
                Console.WriteLine();
                
            }
        }

        static void RightAngleNumber(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void RightAngleNumberRepeat(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void PyramidAscending(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int s = i; s <= rowInput; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void PyramidDescending(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int space = 1; space < i; space++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= 2*(rowInput - i + 1) - 1; j++)
                {
                    Console.Write($"{j,2}");
                }

                Console.WriteLine();
            }
        }
        static void PyramidRepeat(int rowInput)
        {
            for (int i = 1; i <= rowInput; i++)
            {
                for (int s = i; s <= rowInput; s++)
                {
                    Console.Write("  "); 
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write($"{i,2}"); 
                }
                Console.WriteLine();
            }
        }

        static void DiamondAlphabetWay1(int rowInput)
        {
            char ch = 'A';
            for (int i = 1; i < rowInput; i++)
            {
                for (int s = i; s <= rowInput; s++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{ch,2}");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write($"{ch,2}");
                }
                Console.WriteLine();
                ch++;
            }
            
            for (int i = 1; i <= rowInput; i++)
            {
                for (int s = 1; s <= i; s++)
                {
                    Console.Write("  ");
                }

                for (int j = i; j <= rowInput; j++)
                {
                    Console.Write($"{ch,2}");
                }
                for (int j = i; j < rowInput; j++)
                {
                    Console.Write($"{ch,2}");
                }
                Console.WriteLine();
                ch--;
            }
        }

        static void DiamondAlphabetWay2(int rowInput)
        {
            char ch = 'A';
            for (int i = 1; i <= rowInput; i++)
            {
                for (int s = i; s <= rowInput; s++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write($"{ch,2}");
                }
                Console.WriteLine();
                ch++;
            }

            ch = (char)(ch - 2);
            for (int i = 1; i <= rowInput; i++)
            {
                for (int s = 1; s <= i + 1; s++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= 2*(rowInput-i)-1; j++)
                {
                    Console.Write($"{ch,2}");
                }

                Console.WriteLine();
                ch--;
            }
            
        }










    }
}
