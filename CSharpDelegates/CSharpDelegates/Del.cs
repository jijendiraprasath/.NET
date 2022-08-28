using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
    internal class Del
    {
        public static void a1()
        {
            List<int> numb = new List<int>() { 23, 54, 64, 2, 67, 34, 65, 76, 34, 4, 10, 9, 12 };
            int n = 3;
            Int32 length = numb.Count;
            Console.WriteLine("Delegates Method");
            Console.WriteLine("List of Number Divisible by 3 in the list: ");
            for (int i = 0; i < length; i++)
            {
                if (numb[i] % n == 0)
                {
                    Console.WriteLine(numb[i]);
                }
            }
            List<int> divBy3 = numb.FindAll(x => (x % 3) == 0);
            Console.WriteLine("Lambda Expression Method");
            Console.WriteLine("Numbers Divisible by 3 in the list: ");
            foreach (var value in divBy3)
            {
                Console.WriteLine(value);
            }
        }
    }
}
