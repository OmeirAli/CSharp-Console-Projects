using System;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    class TypeInfoAttribute : Attribute
    {
        private string name;
        public string Description;
        public TypeInfoAttribute(string name)
        {
            this.name = name;
        }
    }

    [TypeInfo("user", Description ="User Class")]
    class User
    {
        // [TypeInfo("userid")]
        public int UserId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User obj = new User();

            object[] attrs = obj.GetType().GetCustomAttributes(true);

            foreach (var attr in attrs)
            {
                Console.WriteLine(attr);
            }
            
        }
    }
}