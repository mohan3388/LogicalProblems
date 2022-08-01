using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class PerfectNumber
    {
        public static void Perfect()
        {
            int n, i,sum;
            Console.WriteLine("Perfect number");
            Console.WriteLine("Enter Starting Range: ");
            int mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Range: ");
            int mx = Convert.ToInt32(Console.ReadLine());

            for(n=mn; n<=mx; n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if(n%i==0)
                    
                        sum = sum + i;
                        i++;
                    
                }
                if (sum == n)
                    Console.WriteLine("Perfect number is: "+n);
            }

        }
    }
}
