using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParameters
{
    internal class MonthlyPayment
    {
        public static void a1()
        {
            double M, N, i = 1;
            Console.WriteLine("Enter the Amount to be paid : ");
            M = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Amount paid monthly : ");
            N = Convert.ToDouble(Console.ReadLine());
            while (M > 0)
            {
                double d;
                d = M * 0.015;
                M = M - N;
                M = M + d;
                Console.WriteLine("Month: " + i + "\tBalance: " + M + "\tTotal payments: " + N * i);
                ++i;
            }
            Console.ReadKey();
        }
    }
}
