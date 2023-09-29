namespace TypesOfProperty
{

    class User
    {   
        //read-write
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //write-only
        private DateTime dob;

        public DateTime DOB
        {
            set
            {
                dob = value;
            }
        }
        
        //read-only
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
        }
        
        //auto-implemented property
        public string FullName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
    
}