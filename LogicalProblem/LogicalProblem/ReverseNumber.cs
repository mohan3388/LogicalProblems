using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class ReverseNumber
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter number to Check Reverse Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 0, rem;
            while(num!=0)
            {
                num = num/10;
                res = res * 10 + num;
                num = num%10;
            }
            Console.WriteLine("reverse number: "+res);
        }
    }
}
