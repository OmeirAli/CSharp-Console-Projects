namespace AttributesExample
{
    class User
    {   
        [Obsolete("ShowDetails method is obsolete, use DisplayDetails")]
        public void ShowDetails()
        {
            Console.Write("Old Method");
        }

        public void DisplayDetails()
        {
            Console.Write("New Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.ShowDetails();
        }
    }
}