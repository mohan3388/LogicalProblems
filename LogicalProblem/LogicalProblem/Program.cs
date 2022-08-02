namespace LogicalProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool end = true;
            Console.WriteLine("1. Fabonacci Series\n2. Perfect Number\n3. Prime Number\n4. Reverse Number");
            while (end)
            {
                Console.WriteLine("\nEnter Above Option");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                       
                        FabonaciSeries.FabonacciSeries();
                        break;
                        case 2:
                       
                        PerfectNumber.Perfect();
                        break;
                    case 3:
                        PrimeNumber.Prime();
                        break;
                    case 4:
                        ReverseNumber.Reverse();
                        break;
                    case 5:
                        CoupenNumber.Coupen(21);
                        break;
                }
            }
           
        }
    }
}