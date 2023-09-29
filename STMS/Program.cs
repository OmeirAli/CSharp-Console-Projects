using System;
using System.Runtime.InteropServices.JavaScript;

namespace STMS
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
                string[] studentNames = GetStudentNames(n);
                optionSelect(studentNames);
            }
        }

        private int GetNumberOfStudents()
        {
            while (true)
            {
                Console.Write("How many students would you like to enter?: ");
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

        private string[] GetStudentNames(int n)
        {
            string[] studentNames = new string[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Enter student {i + 1}: ");
                    string userInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("Error! Input cannot be blank!");
                        continue;
                    }

                    if (IsValidName(userInput))
                    {
                        studentNames[i] = userInput;
                        break;
                    }
                    Console.WriteLine("Error! Please enter a valid student name (should only contain letters and spaces)!");
                }
            }
            return studentNames;
        }

        private bool IsValidName(string userInput)
        {
            foreach (char c in userInput)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }

            return true;
        }

        private void optionSelect(string[] studentNames)
        {
            while (true)
            {
                Console.WriteLine("List of students: ");
                for (int i = 0; i < studentNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentNames[i]}");
                }
                Console.WriteLine("Press A or a to add another student. Press R or r to remove a student. Press any other key to quit the program: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'A' || keyChar == 'a')
                {
                    int n = GetNumberOfStudents();
                    string[] newstudentNames = GetStudentNames(n);
                    string[] combinedArray = new string[studentNames.Length + newstudentNames.Length];
                    Array.Copy(studentNames, combinedArray, studentNames.Length);
                    Array.Copy(newstudentNames, 0, combinedArray, studentNames.Length, newstudentNames.Length);
                    studentNames = combinedArray;
                }
                else if (keyChar == 'R' || keyChar == 'r')
                {
                    int numToRemove = GetNumberOfStudents();
                    string[] namesToRemove = GetStudentNames(numToRemove);
                    int countNotRemoved = 0;
                    string[] tempStudentNames = new string[studentNames.Length];
                    foreach (var studentName in studentNames)
                    {
                        bool isToRemove = false;
                        foreach (var name in namesToRemove)
                        {
                            if (studentName == name)
                            {
                                isToRemove = true;
                                Console.WriteLine($"Removed {studentName} from list.");
                                break;
                            }
                        }

                        if (!isToRemove)
                        {
                            tempStudentNames[countNotRemoved++] = studentName;
                        }
                    }

                    string[] newArray = new string[countNotRemoved];
                    Array.Copy(tempStudentNames, newArray, countNotRemoved);
                    studentNames = newArray;
                }
                else
                {
                    Environment.Exit(0);
                }

            }
        }
    }
}