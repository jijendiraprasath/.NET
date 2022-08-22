using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMatrix
{
    internal class AnnualCompoundInterest
    {
        public static void a1()
        {
            double p = 1000, i = 0;
            Console.WriteLine("Year\tIntrest for the year\tEnd of the year amount");
            while (p <= 100000)
            {
                double d = p;
                p = p + p * 0.05;
                i++;
                Console.WriteLine(i + "\t " + d + " *0.05=" + d * 0.05 + "\t " + p);
            }
            Console.ReadKey();
        }
    }
}
