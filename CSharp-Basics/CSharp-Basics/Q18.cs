using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q18
    {
        public static void q18()
        {
            Console.WriteLine("Check whether both the words are same\nEnter word 1");
            string name = Console.ReadLine();
            Console.WriteLine("Enter word 2");
            string name1 = Console.ReadLine();
            //if (name == name1)
            if (String.Equals(name, name1))
            {
                Console.WriteLine("\nBoth are same");
            }
            else
            {
                Console.WriteLine("\nBoth are not same");
            }
        }
    }
}
