using System;

namespace DSACode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntArray arrayInstance = new IntArray();
            arrayInstance.Run();   // Calling the Run method
        }
    }
    
    // Inserting data at the end of an array
    public class IntArray
    {
        public void Run()
        {
            int[] intArray = InsertEndOfArray();  // Using parentheses to call the method
            
            Console.WriteLine("After Inserting at the End:");
            PrintArray(intArray); // Print the array after inserting at the end

            InsertStartOfArray(intArray);

            Console.WriteLine("\nAfter Inserting at the Start:");
            PrintArray(intArray); // Print the array after inserting at the start
            
            InsertAnywhereOfArray(intArray);

            Console.WriteLine("\nAfter Inserting at position 2:");
            PrintArray(intArray); // Print the array after inserting at the start
        }

        private int[] InsertEndOfArray()
        {
            int[] intArray = new int[10];
            int length = 0; // Make a variable to keep the length because .Length is based off capacity and does not track the actual index
            // for loop adds data for us
            for (int i = 0; i < 8; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            intArray[length] = 8;
            length++;

            return intArray;  // Returning the array
        }

        private void InsertStartOfArray(int[] intArray)
        {
            for (int i = 3; i >= 0; i--)
            {
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = 20;
        }
        
        private void InsertAnywhereOfArray(int[] intArray)
        {
            for (int i = 4; i >= 2; i--)
            {
                intArray[i + 1] = intArray[i];
            }

            intArray[2] = 8;
        }

        private void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}