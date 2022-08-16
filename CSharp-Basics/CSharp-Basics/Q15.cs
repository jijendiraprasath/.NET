using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q15
    {
        static void q15()
        {
            int i = 0;
            int a = 0;
            float sum = 0;
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 subjects mark : ");
            //int sum = arr.Sum();
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Subject[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            a = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                if (a > arr[i])
                    a = arr[i];
                sum += arr[i];
            }

            Console.WriteLine("\nTotal Marks: " + sum);
            Console.WriteLine("Average Mark: " + sum / arr.Length);
            Console.WriteLine("Lowest Mark: " + a);
            for (i = 1; i < arr.Length; i++)
            {
                if (a < arr[i])
                    a = arr[i];
            }
            Console.WriteLine("Highest Mark: " + a);
            Array.Sort(arr);

            Console.WriteLine("\nMarks in ascending order");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Array.Reverse(arr);
            Console.WriteLine("\nMarks in descending order");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            q15();
        }
    }
}
