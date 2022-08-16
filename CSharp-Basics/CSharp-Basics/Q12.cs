using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q12
    {
        static void q12()
        {
            int i;
            Console.WriteLine("Numbers divisible by 7 between 200 and 300");
            for (i = 200; i < 300; i++)
            {
                if (i % 7 == 0)
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            q12();
        }
    }
}
