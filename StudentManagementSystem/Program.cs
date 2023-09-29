using System;

namespace StudentManagementSystem
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
                studentNames = OptionSelect(studentNames);
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
                    Console.WriteLine("Error! Only positive whole numbers are accepted!");
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
                    Console.Write($"Enter the name of student {i + 1}: ");
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
                    
                    Console.WriteLine("Error! Input must be a valid name (only letters and spaces)!");
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

        private string[] OptionSelect(string[] studentNames)
        {
            while (true)
            {
                Console.WriteLine("List of Students: ");
                for (int i = 0; i < studentNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentNames[i]}");
                }
                Console.Write("Press a or A to add another student or Press r or R to remove a student or Press any other key to quit: ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'A' || keyChar == 'a')
                {
                    Console.Write("\n");
                    int n = GetNumberOfStudents();
                    string[] newstudentNames = GetStudentNames(n);
                    string[] combinedArray = new string[studentNames.Length + newstudentNames.Length];
                    Array.Copy(studentNames, combinedArray, studentNames.Length);
                    Array.Copy(newstudentNames,0, combinedArray, studentNames.Length,newstudentNames.Length);
                    studentNames = combinedArray;
                }
                else if (keyChar == 'R' || keyChar == 'r')
                {
                    int numToRemove = GetNumberOfStudents("\nEnter the number of students you want to remove?: ");
                    string[] namesToRemove = GetStudentNames(numToRemove);

                    int countNotRemoved = 0;
                    string[] tempArray = new string[studentNames.Length];

                    foreach (var studentName in studentNames)
                    {
                        bool isToRemove = false;
                        foreach (var name in namesToRemove)
                        {
                            if (studentName == name)
                            {
                                isToRemove = true;
                                Console.WriteLine($"Removed {studentName} from the list.");
                                break;
                            }
                        }
                        if (!isToRemove)
                        {
                            tempArray[countNotRemoved++] = studentName;
                        }
                    }

                    // Resize tempArray to actual count of names not removed
                    string[] newArray = new string[countNotRemoved];
                    Array.Copy(tempArray, newArray, countNotRemoved);

                    studentNames = newArray; // Assign the newArray to studentNames


                }

            }
        }
        
    }
}