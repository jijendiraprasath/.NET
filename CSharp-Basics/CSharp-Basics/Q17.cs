using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q17
    {
        static void q17()
        {
            Console.WriteLine("Enter any word to print in reverse");
            string name = Console.ReadLine();
            string rname = string.Empty;
            foreach (char c in name)
            {
                rname = c + rname;
            }
            Console.Write("Reverse of the word: " + rname);
        }
        static void Main(string[] args)
        {
            q17();
        }
    }
}
