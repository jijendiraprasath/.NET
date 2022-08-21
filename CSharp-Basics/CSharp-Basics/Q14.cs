using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q14
    {
        public static void q14()
        {
            int i = 0;
            int a = 0;
            int[] arr = new int[5];
            Console.WriteLine("Enter any 5 values : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Value[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            a = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                if (a > arr[i])
                    a = arr[i];
            }
            Console.WriteLine("Smallest value is : " + a);
            for (i = 1; i < arr.Length; i++)
            {
                if (a < arr[i])
                    a = arr[i];
            }
            Console.WriteLine("Largest value is : " + a);
        }
    }
}
