using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q13
    {
        static void q13()
        {
            int a, b, c;
            Console.WriteLine("Finding the largest of 3 numbers");
            Console.WriteLine("Enter value one:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value two:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value three:");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("{0} is the largest number", a);
                }
                else
                {
                    Console.Write("{0} is the largest number", c);
                }
            }
            else if (b > c)
            {
                Console.Write("{0} is the largest number", b);
            }
            else
            {
                Console.Write("{0} is the largest number", c);
            }
        }
        static void Main(string[] args)
        {
            q13();
        }
    }
}
