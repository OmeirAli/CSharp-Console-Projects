using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }

            Console.ReadLine();

        }
    }
}