using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLINQ
{
    internal class Even
    {
        public static void enums()
        {
            int[] n = { 12, 98, 23, 87, 34, 76, 45, 32, 74 };
            Console.WriteLine("even values from array and count");
            int evenCount = n.Where(e => e % 2 == 0).Count();
            var result = from i in n
                         where i % 2 == 0
                         select i;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Count of even numbers: {evenCount}");

        }
    }
}
