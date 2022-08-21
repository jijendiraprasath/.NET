using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q9
    {
        public static void q9()
        {
            int a, b, c = 1;
            Console.WriteLine("Find the factorial");
            b = int.Parse(Console.ReadLine());
            for (a = 1; a <= b; a++)
            {
                c = c * a;
            }
            Console.WriteLine("Factorial of {0} is {1}", b, c);
        }
    }
}
