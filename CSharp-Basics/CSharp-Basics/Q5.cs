using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q5
    {
        public static void q5()
        {
            int i, n, even = 0, odd = 0;
            Console.WriteLine("Enter input to find count of odd and even: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter Values:");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Total even numbers: " + even);
            Console.WriteLine("Total odd numbers: " + odd);
            Console.ReadLine();
        }
    }
}
