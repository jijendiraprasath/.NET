using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q3
    {
        static void q3()
        {
            int a, b, i, odd = 0, even = 0;
            Console.WriteLine("\nDisplay all the numbers between the given two numbers.");
            Console.WriteLine("Enter Start Value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End Value:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers between {0} and {1} are", a, b);
            for (i = a; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            q3();
        }
    }
}
