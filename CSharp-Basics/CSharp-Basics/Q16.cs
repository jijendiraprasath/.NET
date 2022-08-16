using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q16
    {
        static void q16()
        {
            Console.WriteLine("Enter any word to find its length");
            string name = Console.ReadLine();
            int a = name.Length;
            Console.WriteLine("\nLength of the word: " + a);
        }
        static void Main(string[] args)
        {
            q16();
        }
    }
}
