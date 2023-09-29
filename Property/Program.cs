using System;

namespace LoggingIn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User();
                //user.FirstName = "";
                //Console.Write("\n First Name: {0}", user.FirstName);
                user.FirstName = "Omeir";
                user.LastName = "Ali";
                Console.WriteLine("My Full Name: {0}", user.FullName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }
    }

    class User
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("argument value can not be null or empty");
                }
                else
                {
                    firstName = value;
                    fullName = firstName + " " + lastName;
                }
                
            }
        }

        private string lastName;

        public string LastName
        {
            get {
                return lastName;
            }
            set {
                lastName = value;
                fullName = firstName + " " + lastName;
            }
        }
        
        private string fullName;

        public string FullName
        {
            get {
                return fullName;
            }
            
        }
    }
}