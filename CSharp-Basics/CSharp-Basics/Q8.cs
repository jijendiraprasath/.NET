using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q8
    {
        public static void q8()
        {
            int a, b;
            Console.WriteLine("To get 0,1,4,9,16 number sequence");
            Console.WriteLine("Enter limit: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (a = 0; a <= b; a++)
            {
                Console.WriteLine("\n{0} ", a * a);
            }
        }
    }
}
