using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q19
    {
        public static void q19()
        {
            Console.WriteLine("\nPalindrome check");
            string x, y = "";
            Console.WriteLine("Enter the word");
            x = Console.ReadLine();
            for (int i = x.Length - 1; i >= 0; i--)
            {
                y += x[i].ToString();
            }
            if (y == x)
            {
                Console.WriteLine("Entered word is a Palindrome");
            }
            else
            {
                Console.WriteLine("Entered word is not a Palindrome");
            }
            Console.ReadKey();
        }
    }
}
