using System;

namespace AsyncReturnTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var result1 = methodAsync1(5);
            //result1.Wait(); 
            //result1.GetAwaiter().GetResult();
            
            var result2 = methodAsync2(5);
            result2.Wait(); 
            Console.WriteLine($"async method returned value: {result2.Result}");
        }

        private static Task methodAsync1(int count)
        {
            Task task = new Task(() =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Thread.Sleep(200);
                    string message = $"async number: {i}";
                    PrintAsync(message);
                    //Console.WriteLine(message);
                    //throw new IndexOutOfRangeException("index out of range");
                }
            });
            task.Start();
            return task;

            
        }
        
        private static Task<int> methodAsync2(int count)
        {
            int result = 0;
            Task<int> task = new Task<int>(() =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Thread.Sleep(200);
                    string message = $"async number: {i}";
                    PrintAsync(message);
                    result += i;
                }

                return result;
            });
            task.Start();
            return task;

            
        }
        private static void PrintAsync(string message)
        {
            Task task = new Task(() =>
            {
                Console.WriteLine(message);
            });
            task.Start();
        }
    }
}