using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParameters
{
    internal class Sum
    {
        public static void sum()
        {
            int m, n;
            Console.Write("Enter first value: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            n = Convert.ToInt32(Console.ReadLine());
            int sum = m + n;
            Console.Write("sum of both the values: " + sum);
            Console.WriteLine("\n");
        }
    }
}
