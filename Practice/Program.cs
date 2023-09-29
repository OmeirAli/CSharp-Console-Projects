using System;

//namespace Practice
//{
//    public class Student
//    {   
//        //fields
//        public int StudentId { get; set; }
//        public string Name { get; set; }
//        public string Address { get; set; }
//        
//        //methods
//        public void ShowDetails()
//        {
//            Console.WriteLine("Student Information");
//            Console.WriteLine("StudentId: {0}, Name: {1}, Address: {2}", StudentId, Name, Address);
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Student st = new Student();
//            st.StudentId = 1;
//            st.Name = "Omeir";
//            st.Address = "Sydney";
//            st.ShowDetails();
//            Console.ReadKey();
//        }
//    }
//}

//namespace Default_ParameterizedConstructor
//{
//    public class Student
//    {   
//        public int StudentId { get; set; }
//        public string Name { get; set; }
//        public string College { get; set; }
//        public Student()
//        {
//            College = "IMR College";
//        }
//        
//        //Parameterized Constructor
//        public Student(int StudentId, string name, string college)
//        {
//            this.StudentId = StudentId;
//            this.Name = name;
//            this.College = college;
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            //Student st = new Student();
//            //Console.WriteLine("StudentId: {0}, Name: {1}, College: {2}", st.StudentId, st.Name, st.College);
//            //Console.ReadKey();
//
//            Student st = new Student(1,"Omeir", "UNE");
//            Console.WriteLine("StudentId: {0}, Name: {1}, College: {2}", st.StudentId, st.Name, st.College);
//            Console.ReadKey();
//        }
//    }
//}
namespace MethodOverloadingAndOverriding
{
    class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Add(double num1, int num2)
        {
            return num1 + num2;
        }

        public decimal Add(decimal num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double result = calc.Add(1.5, 2);
            Console.Write(result);

            Console.ReadKey();
        }
    }
}
