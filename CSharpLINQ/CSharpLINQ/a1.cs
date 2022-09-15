using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLINQ
{
    internal class a1
    {
        public static void cube()
        {
            int x;
            Console.WriteLine("Enter array limit: ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            Console.WriteLine("Enter array valuee: ");
            for (int i = 0; i < x; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Cube of eleents in array are: ");
            /*for(int i = 0; i < x; i++)
            {
                Console.Write("{0}\t", arr[i]);
                Console.WriteLine("\n");
            }*/
            foreach (int i in arr)
            {
                Console.WriteLine("{0}\t", i * i * i);
                Console.WriteLine("\n");
            }
            var result = from i in arr
                         let a = i * i * i
                         where a > 100 && a < 1000
                         select a;
            foreach (var i in result)
                Console.WriteLine("{0}", i);
                Console.ReadKey();
        }
    }
}
