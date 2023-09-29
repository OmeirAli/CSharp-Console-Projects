using System;

namespace Test1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] marks = new int[5]{60,70,66,68,80};
            marks[0] = 60;
            marks[1] = 70;
            marks[2] = 66;
            marks[3] = 68;
            marks[4] = 80; 
            Console.WriteLine("Elements Of Array: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("\t" + marks[i]);
            } 
            int[,] matrix = new int[2, 3]
            {
                {10,20,30},
                {40,50,60}
            };
            matrix[0, 0] = 10;
            matrix[0, 1] = 20;
            matrix[0, 2] = 30;
            
            matrix[1, 0] = 40;
            matrix[1, 1] = 50;
            matrix[1, 2] = 60;
                                  Console.Write("Elements in a matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Row #{0} Elements : ", (i+1));
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrix[i,j]);
                }
            }
            int [] arr = new int[]{5,2,12,1};
            Array.Sort(arr);
            Console.WriteLine("Sorted Array Elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            int index = Array.IndexOf(arr, 12);
            Console.Write("\n Index of 12 is: {0}", index);
            int[,] TwoDArray = new int[3, 4]
            {
                {2,4,5,6},
                {4,8,9,7},
                {4,12,4,7}
                
            };

        }
    }
}