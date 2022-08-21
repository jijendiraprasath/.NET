using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollection
{
    internal class StuDesc
    {
        public static void a2()
        {
            List<string> students = new List<string>(){ "Jije", "Jijendira", "Prasath" };
            var result = students.OrderByDescending(n => n);
            Console.Write("Sorted list in Descending order:\n");
            foreach (string student in result)
            {
                Console.Write(student + " ");
            }
            Console.ReadKey();
        }
    }
}
