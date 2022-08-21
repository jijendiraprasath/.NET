using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q16
    {
        public static void q16()
        {
            Console.WriteLine("Enter any word to find its length");
            string name = Console.ReadLine();
            int a = name.Length;
            Console.WriteLine("\nLength of the word: " + a);
        }
    }
}
