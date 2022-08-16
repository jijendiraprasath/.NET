using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q4
    {
        static void q4()
        {
            int a, b, i, odd = 0, even = 0;
            Console.WriteLine("\nFind Odd / Even");
            Console.WriteLine("Enter any Value:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Entered value \t{0} is an Even number", a);
            }
            else
            {
                Console.WriteLine("Entered value \t{0} is an Odd number", a);
            }
        }
        static void Main(string[] args)
        {
            q4();
        }
    }
}
