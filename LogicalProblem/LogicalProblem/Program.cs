namespace LogicalProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool end = true;
            Console.WriteLine("1. Fabonacci Series\n2. Perfect Number");
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
                }
            }
           
        }
    }
}