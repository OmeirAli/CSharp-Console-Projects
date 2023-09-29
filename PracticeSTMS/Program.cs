using System;

namespace PracticeSTMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentClass studentClass = new StudentClass();
            studentClass.Run();
        }
    }

    public class StudentClass
    {
        public void Run()
        {
            while (true)
            {
                int n = GetNumberOfStudents();
            }
        }

        private int GetNumberOfStudents(string prompt = "How many students would you like to enter?: ")
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

                if (!int.TryParse(userInput, out int n) || n <= 0)
                {
                    Console.WriteLine("Error! Input can only be a positive whole number!");
                    continue;
                }

                return n;
            }
        }
    }
}