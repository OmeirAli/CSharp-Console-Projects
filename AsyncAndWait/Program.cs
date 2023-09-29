using System;

namespace AsyncAndAwait
{

    public class Employee
    {
        public async Task<string> GetDataAsync()
        {
            HttpClient client = new HttpClient();
            Uri apiAddress = new Uri("https://jsonplaceholder.typicode.com/todos");
            var task = await client.GetAsync(apiAddress);
            if (task.IsSuccessStatusCode)
            {
                var data = await task.Content.ReadAsStringAsync();
                return data;
            }
            else
            {
                return null;
            }
        }
    }
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Employee emp = new Employee();
            var task = await emp.GetDataAsync();
            Console.WriteLine(task);
        }
    }
}