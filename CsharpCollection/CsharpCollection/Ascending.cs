using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollection
{
    internal class Ascending
    {
        public static void a1()
        {
            int i = 0;
            int a = 0;
            float sum = 0;
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 values: ");
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
                sum += arr[i];
            }
            for (i = 1; i < arr.Length; i++)
            {
                if (a < arr[i])
                    a = arr[i];
            }
            Array.Sort(arr);
            Console.WriteLine("\nValues sorted in ascending order");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
