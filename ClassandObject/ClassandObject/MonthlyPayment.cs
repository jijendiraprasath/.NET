using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class MonthlyPayment
    {
        public static void a1()
        {
            Double M, N, i = 1;
            Console.WriteLine("Enter the Amount to be paid : ");
            M = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Amount paid monthly : ");
            N = Convert.ToDouble(Console.ReadLine());
            while (M > 0)
            {
                Double d;
                d = M * 0.015;
                M = M - N;
                M = M + d;
                Console.WriteLine("Month:" + i + "  balance: " + M + "         total payments: " + N * i);
                ++i;
            }
            Console.ReadKey();
        }
    }
}
