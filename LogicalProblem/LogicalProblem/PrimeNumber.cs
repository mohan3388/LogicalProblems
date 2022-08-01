using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class PrimeNumber
    {

        public static void Prime()
        {
            int count = 0;
            Console.WriteLine("Check the Number is Prime or not");

            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(a + " is Prime Number\n");
            }
            else
            {
                Console.WriteLine(a + " is Not Prime Number\n");
            }
        }
    }
}
