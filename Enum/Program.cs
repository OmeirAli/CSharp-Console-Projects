namespace Enum
{
    enum Weekdays
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }

    enum TransactionStatus
    {
        Success = 1, Pending = 4, Failed = 10
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("{0} = {1}", Weekdays.Mon, (int)Weekdays.Mon);
            //Console.WriteLine("{0} = {1}", Weekdays.Tue, (int)Weekdays.Tue);
            //
            //Console.WriteLine("{0} = {1}", TransactionStatus.Success, (int)TransactionStatus.Success);
            //Console.WriteLine("{0} = {1}", TransactionStatus.Failed, (int)TransactionStatus.Failed);

            string status = ProcessPayment(100, 3400);
            if (status == TransactionStatus.Success.ToString())
            {
                Console.Write("\n Transaction is successful");
            }
            else
            {
                Console.Write("\n Transaction is failed");
            }
        }

        static string ProcessPayment(int tranId, int amount)
        {
            if (amount > 0)
            {
                return "Success";
            }
            else
            {
                return "Failed";
            }
        }
    }
}