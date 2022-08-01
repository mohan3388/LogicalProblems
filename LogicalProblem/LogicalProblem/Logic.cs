using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Logic
    {
        public static void FabonacciSeries()
        {
            int n1=0, n2=1,i,n3;
            Console.WriteLine("Fabonacci Series");
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " , " + n2+" , ");
            for(i=2; i<num;i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write("{0} , ", n3);
            }
        }
    }
}
