using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q10
    {
        public static void q10()
        {
            int a = 0, b = 1, c, d, i;
            Console.WriteLine("Fibonacci series\nEnter the range:");
            d = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < d; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                //if (c == 40);
                //break;
            }
        }
    }
}
