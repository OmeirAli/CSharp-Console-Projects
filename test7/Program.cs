using System;

class Program
{
    static void Main(string[] args)
    {
        string[] I = 
        { 
            " * ",
            " * ",
            " * ",
            " * ",
            " * " 
        };

        string[] L = 
        { 
            "*   ",
            "*   ",
            "*   ",
            "*   ",
            "****" 
        };

        string[] O = 
        { 
            " *** ",
            "*   *",
            "*   *",
            "*   *",
            " *** " 
        };

        string[] V = 
        { 
            "*   *",
            "*   *",
            " * * ",
            "  *  ",
            "  *  " 
        };

        string[] E = 
        { 
            "*****",
            "*    ",
            "**** ",
            "*    ",
            "*****" 
        };

        string[] Y = 
        { 
            "*   *",
            " * * ",
            "  *  ",
            "  *  ",
            "  *  " 
        };

        string[] U = 
        { 
            "*   *",
            "*   *",
            "*   *",
            "*   *",
            " *** " 
        };

        string[][] letters = { I, null, L, O, V, E, null, Y, O, U };

        for (int i = 0; i < 5; i++)
        {
            foreach (string[] letter in letters)
            {
                if (letter == null)
                {
                    Console.Write("     ");
                }
                else
                {
                    Console.Write(letter[i]);
                    Console.Write("   ");
                }
            }
            Console.Write("     ");  // Space between words and heart
            if (i >= 2) DrawHeart(i - 2, 6);  // Delay start of heart by 2 lines
            Console.WriteLine();
        }

        for (int i = 6; i >= 1; i--)
        {
            Console.Write("                                           ");  // Align with the heart
            DrawHeart(i, 6);
            Console.WriteLine();
        }
    }

    static void DrawHeart(int i, int n)
    {
        int j;

        // upper part of the heart
        if (i <= n / 2)
        {
            for (j = 1; j < n - i; j += 2)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            for (j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
        }
        // lower part of the heart
        else
        {
            for (j = i - n / 2; j < n; j++)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= (n - i) * 2 - 1; j++)
            {
                Console.Write("*");
            }
        }
    }
}
