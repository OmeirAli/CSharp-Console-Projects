namespace CustomException
{

    class UserDefinedException : Exception
    {
        public UserDefinedException(string msg): base(msg)
        {
            
        }
        public UserDefinedException(string msg, Exception innerEx): base(msg, innerEx)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 2, y = -1, result;
                if (y <= 0)
                {
                    throw new UserDefinedException("Y should be greater than 0");
                }
                else
                {
                    result = x / y;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}