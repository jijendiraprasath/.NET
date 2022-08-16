using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q11
    {
        static void q11()
        {
            int i, n;
            Console.WriteLine("Multiplication table");
            Console.WriteLine("Enter Value:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} * {1} = {2} \n", n, i, n * i);
            }
        }
        static void Main(string[] args)
        {
            q11();
        }
    }
}
